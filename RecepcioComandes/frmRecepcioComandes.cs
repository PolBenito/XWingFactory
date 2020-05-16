using Persistencia;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;
using System.Data;

namespace RecepcioComandes
{
    public partial class frmRecepcioComandes : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        private bool error_download = false;

        public frmRecepcioComandes()
        {
            InitializeComponent();
        }

        private void DescargarEDI()
        {
            string pathFolder = Application.StartupPath + "/EDI";
            string pathFile = pathFolder + "/comandes.edi";

            try
            {
                if (!Directory.Exists(pathFolder))
                {
                    Directory.CreateDirectory(pathFolder);
                }
                else if (File.Exists(pathFile))
                {
                    File.Delete(pathFile);
                }

                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://172.17.6.0/comandes.edi");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("thegungans", "12345aA");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                StreamWriter writer = new StreamWriter(pathFile);

                writer.Write(reader.ReadToEnd());
                writer.Flush();
                writer.Close();

                reader.Close();
                response.Close();
            }
            catch
            {
                error_download = true;

                MessageBox.Show(
                    "El fitxer que esta buscant no existeix en aquests moments.",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LeerEDI()
        {
            string pathFile = Application.StartupPath + "\\EDI\\comandes.edi";

            const int val100 = 100;
            const int val = 6;

            string [,] detalles_comanda = new string [val100,val];
            string [] v_lineas;

            string linea = "";
            string tipo_pedido = "";
            string zona_operativa = "";
            string codigo_emisor_pedido = "";
            string receptor = "";
            int day = 0, month = 0, year = 0;
            int count = 0;
            int count_detalles = 0;
            bool sortir = false;
            bool sortir_default = false;

            try
            {
                using (StreamReader file = new StreamReader(pathFile))
                {
                    while (((linea = file.ReadLine()) != null) && !sortir && !sortir_default)
                    {
                        if (count == 0)
                        {
                            if (linea != "ORDERS_D_96A_UN_EAN008")
                            {
                                sortir = true;
                            }
                        }
                        else
                        {
                            v_lineas = linea.Split('|');

                            string nom = v_lineas[0];

                            switch (nom)
                            {
                                case "ORD":

                                    string pedido = v_lineas[1];

                                    if (pedido.Length == 12)
                                    {
                                        string tipo = v_lineas[2];

                                        if (tipo.Length == 3)
                                        {
                                            if (tipo == "22E")
                                            {
                                                //tipo_pedido = "pedido urgente";
                                                tipo_pedido = "2E";
                                            }
                                            else if (tipo == "220")
                                            {
                                                //tipo_pedido = "pedido normal";
                                                tipo_pedido = "20";
                                            }
                                            else
                                            {
                                                sortir = true;
                                            }
                                        }
                                        else
                                        {
                                            sortir = true;
                                        }
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    break;

                                case "DTM":

                                    string documento = v_lineas[1];

                                    if (documento.Length == 8)
                                    {
                                        try
                                        {
                                            Int32.Parse(documento);

                                            //year = Int32.Parse(documento.Substring(0, 4));
                                            year = Int32.Parse(documento.Substring(2, 2));
                                            month = Int32.Parse(documento.Substring(4, 2));
                                            day = Int32.Parse(documento.Substring(6, 2));
                                        }
                                        catch
                                        {
                                            sortir = true;
                                        }
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    break;

                                case "NADMS":

                                    string area_operativa = v_lineas[1];

                                    if (area_operativa.Length == 5)
                                    {
                                        switch (area_operativa)
                                        {
                                            case "OUTER":

                                                //zona_operativa = "Outer Ring";
                                                zona_operativa = "O";

                                                break;

                                            case "INNER":

                                                //zona_operativa = "Inner Ring";
                                                zona_operativa = "I";

                                                break;

                                            case "UNKNO":

                                                //zona_operativa = "Unknown";
                                                zona_operativa = "U";

                                                break;

                                            default:

                                                sortir = true;

                                                break;
                                        }

                                        string emisor = v_lineas[2];

                                        if (emisor.Length == 3)
                                        {
                                            if (emisor == "37E")
                                            {
                                                //codigo_emisor_pedido = "High command of strategic operations";
                                                codigo_emisor_pedido = "37E";
                                            }
                                            else if (emisor == "40A")
                                            {
                                                //codigo_emisor_pedido = "High Jedi Council";
                                                codigo_emisor_pedido = "40A";
                                            }
                                            else
                                            {
                                                sortir = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    break;

                                case "NADMR":

                                    receptor = v_lineas[1];

                                    if (receptor.Length != 12)
                                    {
                                        receptor = "";
                                        sortir = true;
                                    }

                                    break;

                                case "LIN":

                                    string planeta_destino = v_lineas[1];

                                    if (planeta_destino.Length == 11 || planeta_destino.Length == 12)
                                    {
                                        planeta_destino = planeta_destino.Substring(planeta_destino.Length - 4, 4);

                                        detalles_comanda[count_detalles,0] = planeta_destino;

                                        string codigo = v_lineas[2];

                                        if (codigo.Length == 13)
                                        {
                                            detalles_comanda[count_detalles,1] = codigo;

                                            string tipo_codigo = v_lineas[3];

                                            if (tipo_codigo.Length == 2)
                                            {
                                                string tipo_codificacion = "";

                                                if (tipo_codigo == "EN")
                                                {
                                                    tipo_codificacion = "EAN13DUN14";
                                                }
                                                else if (tipo_codigo == "UP")
                                                {
                                                    tipo_codificacion = "UPC";
                                                }
                                                else
                                                {
                                                    sortir = true;
                                                }

                                                detalles_comanda[count_detalles,2] = tipo_codificacion;
                                            }
                                            else
                                            {
                                                sortir = true;
                                            }
                                        }
                                        else
                                        {
                                            sortir = true;
                                        }
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    break;

                                case "QTYLIN":

                                    string calificador = v_lineas[1];

                                    if (calificador.Length == 2)
                                    {
                                        string tipo_calificador = "";

                                        if (calificador == "21")
                                        {
                                            tipo_calificador = "pedidos";
                                        }
                                        else if (calificador == "61")
                                        {
                                            tipo_calificador = "devoluciones";
                                        }
                                        else
                                        {
                                            sortir = true;
                                        }

                                        detalles_comanda[count_detalles,3] = tipo_calificador;

                                        string cantidad = v_lineas[2];

                                        if (cantidad.Length <= 15)
                                        {
                                            detalles_comanda[count_detalles,4] = cantidad;
                                        }
                                        else
                                        {
                                            sortir = true;
                                        }
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    break;

                                case "DTMLIN":

                                    string fecha_entrega = v_lineas[1];

                                    if (fecha_entrega.Length == 8)
                                    {
                                        detalles_comanda[count_detalles,5] = fecha_entrega;
                                    }
                                    else
                                    {
                                        sortir = true;
                                    }

                                    count_detalles++;

                                    break;

                                default:

                                    sortir_default = true;

                                    break;
                            }
                        }

                        count++;
                    }

                    file.Close();
                }

                if (sortir)
                {
                    MessageBox.Show(
                        "Hi ha un error en la vostra comanda!",
                        "TheGungans Developers",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {
                    string data = year.ToString() + "-" + month.ToString() + "-" + day.ToString();
                    string data_code_order = year.ToString() + month.ToString() + day.ToString();
                    string code_order = data_code_order + tipo_pedido + zona_operativa + codigo_emisor_pedido;

                    GuardarCodeOrder(data, code_order);
                    GuardarOrdersDetails(detalles_comanda, code_order, count_detalles);

                    lbComandes.Text = code_order;

                    MessageBox.Show(
                        "Fitxer llegit correctament!",
                        "TheGungans Developers",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                error_download = true;

                MessageBox.Show(
                    ex.ToString(),
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void GuardarCodeOrder(string data, string code_order)
        {
            db.Orders.Add(new Orders
            {
                codeOrder = code_order,
                dateOrder = Convert.ToDateTime(data)
            });

            db.SaveChanges();
        }

        private void GuardarOrdersDetails(string [,] detalles_comanda, string code_order, int count)
        {
            int year, month, day;
            string nom_planeta = "";
            string referencia = "";
            string tipo_codificacion = "";
            string tipo_calificador = "";
            string cantidad = "";
            string fecha_entrega = "";


            var queryOrder = (from o in db.Orders
                              where o.codeOrder == code_order
                              select o.idOrder).FirstOrDefault();


            for (int i = 0; i<count; i++)
            {
                nom_planeta = detalles_comanda[i, 0];
                referencia = detalles_comanda[i, 1];
                tipo_codificacion = detalles_comanda[i, 2];
                tipo_calificador = detalles_comanda[i, 3];
                cantidad = detalles_comanda[i, 4];
                fecha_entrega = detalles_comanda[i, 5];

                year = Int32.Parse(fecha_entrega.Substring(0, 4));
                month = Int32.Parse(fecha_entrega.Substring(4, 2));
                day = Int32.Parse(fecha_entrega.Substring(6, 2));

                fecha_entrega = year.ToString() + "-" + month.ToString() + "-" + day.ToString();

                var queryPlaneta = (from p in db.Planets
                                    where p.CodePlanet == nom_planeta
                                    select p.idPlanet).FirstOrDefault();

                var queryReferences = (from r in db.References
                                       where r.codeReference == referencia
                                       select r.idReference).FirstOrDefault();

                if (tipo_calificador == "pedidos")
                {
                    db.OrdersDetail.Add(new OrdersDetail
                    {
                        idOrder = queryOrder,
                        idPlanet = Int16.Parse(queryPlaneta.ToString()),
                        idReference = queryReferences,
                        Quantity = Int16.Parse(cantidad),
                        DeliveryDate = Convert.ToDateTime(fecha_entrega)
                    });
                }


                db.SaveChanges();
            }            
        }

        private void EliminarEDI()
        {
            try
            {
                FtpWebRequest deleteRequest = (FtpWebRequest)WebRequest.Create("ftp://172.17.6.0/comandes.edi");

                deleteRequest.Credentials = new NetworkCredential("thegungans", "12345aA");
                deleteRequest.Method = WebRequestMethods.Ftp.DeleteFile;

                deleteRequest.GetResponse();
            }
            catch
            {
                MessageBox.Show(
                    "El fitxer que esta buscant no existeix en aquests moments.",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            
        }

        private void btProcessarComandes_Click(object sender, EventArgs e)
        {
            DescargarEDI();

            if (!error_download)
            {
                LeerEDI();

                if (!error_download)
                {
                    EliminarEDI();
                }
            }
        }

        private void btMostrarCR_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + "//CrystalReport.rpt");
            cryRpt.SetDatabaseLogon("gungan", "12345aA12345aA", "XWingsFactory", "thegungansalesians.database.windows.net");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
        }
    }
}