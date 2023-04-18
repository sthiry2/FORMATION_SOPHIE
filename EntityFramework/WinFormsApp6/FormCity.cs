using Microsoft.EntityFrameworkCore;
using WinFormsApp6.Models;

namespace WinFormsApp6
{
    public partial class FormCity : Form
    {
        private CitiesContext dbContext;
        public FormCity()
        {
            InitializeComponent();
            //Creer le context vers la source
            dbContext = new CitiesContext();
            //Chargement de la table Cities
            dbContext.Cities.Load();

            //Realisation d'un binding entre la source de donn�e Cities et le datagridview
            this.dataGridViewCities.DataSource = dbContext.Cities.Local.ToBindingList();

        }

        private void Trace(string message)
        {
            textBoxConsole.Text += "-----------------------" + message + "------------------------" + Environment.NewLine;
            dbContext.ChangeTracker.DetectChanges();
            textBoxConsole.Text += dbContext.ChangeTracker.DebugView.LongView;
        }

        private void buttonAjouterUnCitY_Click(object sender, EventArgs e)
        {

            City c = new City();
            c.CityName = "PewGraveCity";
            c.CountryCode = "US";

            Trace("Avant de l'avoir Add");
            dbContext.Cities.Add(c);
            Trace("Apres de l'avoir Add");

            dbContext.SaveChanges();

            Trace("Apres de avoir sauvegard� les changements: un INSERT � �t� r�alis� sur la BD");
        }

        private void buttonSuprimerUnCity_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(this.textBoxId.Text, out id);
            if (idOk)
            {
                City? cASupprimer = dbContext.Cities.Find(id);
                if (cASupprimer != null)
                {
                    dbContext.Cities.Remove(cASupprimer);
                    Trace("Apres l'avoir Remove");

                    dbContext.SaveChanges();
                    Trace("Apres avoir sauvegard� les changements: un DELETE � �t� r�alis� sur la BD");
                }
            }
        }

        private void buttonSuprimerUnCity_Click2(object sender, EventArgs e)
        {
            // ne marche pas
            //https://stackoverflow.com/questions/16194162/entitystate-deleted-does-not-work-removeentity-does
            int id;
            bool idOk = int.TryParse(this.textBoxId.Text, out id);
            if (idOk)
            {
                City cityASupprimer = new City() { CityId = id };
                dbContext.Entry(cityASupprimer).State = EntityState.Deleted;

                Trace("Apres l'avoir dit quel City � definir comme supprimer");

                dbContext.SaveChanges();
                Trace("Apres avoir sauvegard� les changements: un DELETE � �t� r�alis� sur la BD");
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxConsole.Clear();
        }

        private void buttonModifyUnCity_Click(object sender, EventArgs e)
        {
            int id;
            bool idOk = int.TryParse(this.textBoxId.Text, out id);
            string nouveauNom = this.textBoxNom.Text;
            if (idOk)
            {
                City? cAModifier = dbContext.Cities.Find(id);
                if (cAModifier != null)
                {
                    cAModifier.CityName = this.textBoxNom.Text;

                    dbContext.Cities.Update(cAModifier);
                    Trace("Apres l'avoir Modifier");

                    dbContext.SaveChanges();
                    Trace("Apres avoir sauvegard� les changements: un UPDATE � �t� r�alis� sur la BD");
                }
            }
        }
    }
}