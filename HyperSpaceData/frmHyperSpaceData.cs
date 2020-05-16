using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Persistencia;
using System.Linq;
using System.Collections.Generic;

namespace HyperSpaceData
{
    public partial class frmHyperSpaceData : Proj1.PlantillaXWF
    {
        XWingsFactoryEntities db = new XWingsFactoryEntities();

        public frmHyperSpaceData()
        {
            InitializeComponent();
        }

        private void btXML_Click(object sender, EventArgs e)
        {
            string pathFolder = Application.StartupPath + "/XML";
            string pathFile = pathFolder + "/HyperSpaceData.xml";


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

                var queryHSRoutes = (from ro in db.Routes
                                     join rt in db.RouteTypes on ro.idRouteType equals rt.idRouteType
                                     join p in db.Planets on ro.idPlanetOr equals p.idPlanet
                                     join p2 in db.Planets on ro.idPlanetDest equals p2.idPlanet
                                     select new { rt.DescRouteType, ro.DescRoute, p.DescPlanet, PlanetDescripcio = p2.DescPlanet }).ToList();

                var queryDefinedRoutes = (from dr in db.DefinedRoutes
                                          join p in db.Planets on dr.idPlanetOri equals p.idPlanet
                                          join p2 in db.Planets on dr.idPlanetDest equals p2.idPlanet
                                          join r in db.Routes on dr.idRoute equals r.idRoute
                                          select new { p.DescPlanet, PlanetaDescripcio = p2.DescPlanet, r.DescRoute, dr.RouteMap }).ToList();

                var queryFiliations = (from f in db.Filiations
                                       select f.DescFiliations).ToList();

                var queryRegions = (from r in db.Regions
                                    select new { r.DescRegion, r.Remarks }).ToList();

                var queryPlanets = (from p in db.Planets
                                    join sc in db.Sectors on p.idSector equals sc.idSector
                                    join f in db.Filiations on p.idFiliation equals f.idFiliation
                                    join sp in db.Species on p.idNatives equals sp.idSpecie
                                    join r in db.Regions on sc.idRegion equals r.idRegion
                                    select new { p.DescPlanet, sc.DescSector, r.DescRegion, f.DescFiliations, p.@long, p.lat, p.parsecs, sp.DescSpecie }).ToList();


                XElement xml =
                    new XElement("hyperSpacedata",
                        new XElement("hyperspaceRoutes",
                            from r in queryHSRoutes
                            select new XElement("Route",
                                new XElement("type", r.DescRouteType),
                                new XElement("nameRoute", r.DescRoute),
                                new XElement("start", r.DescPlanet),
                                new XElement("end", r.PlanetDescripcio)
                            ),
                            from dr in queryDefinedRoutes
                            select new XElement("defineRoute",
                                new XElement("OrDes", dr.DescPlanet + "-" + dr.PlanetaDescripcio),
                                new XElement("selectedRoute", dr.DescRoute),
                                new XElement("map", dr.RouteMap)
                            )
                        ),
                        new XElement("filiations",
                            from f in queryFiliations
                            select new XElement("description", f)
                        ),
                        new XElement("regions",
                            from r in queryRegions
                            select new XElement("Region",
                                new XElement("nameRegion", r.DescRegion),
                                new XElement("descriptionRegion", r.Remarks)
                            )
                        ),
                        new XElement("planets",
                            from p in queryPlanets
                            select new XElement("planet",
                                new XElement("name", p.DescPlanet),
                                new XElement("sector", p.DescSector + "-" + p.DescRegion),
                                new XElement("filiation", p.DescFiliations),
                                new XElement("situation",
                                    new XElement("long", p.@long),
                                    new XElement("lat", p.lat),
                                    new XElement("parsecs", p.parsecs)
                                ),
                                new XElement("hyperspaceRoute",
                                    new XElement("route", "Corellian Run"),
                                    new XElement("route", "Ison Trade Corridor")
                                ),
                                new XElement("natives", p.DescSpecie),
                                new XElement("landingDefault", "")
                            )
                        )
                    );

                xml.Save(pathFile);

                richTextBox.Text = File.ReadAllText(pathFile);

                MessageBox.Show(
                    "El fitxer s'ha creat correctament!",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hi ha hagut un error al crear el fitxer.",
                    "TheGungans Developers",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
