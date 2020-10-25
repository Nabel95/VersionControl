using MikroSzim.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroSzim
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();
        List<int> men = new List<int>();
        List<int> women = new List<int>();
        Random rng = new Random(1234);

        public Form1()
        {
            InitializeComponent();
            
        }
        private void DisplayResults()
        {
            int x = 0;
            for (int y=2005; y<= finalyearbox.Value; y++)
            {
                richTextBox1.AppendText("Szimulációs év: " + y+"\n");
                richTextBox1.AppendText("\t" + "Fiúk: " + men[x] + "\n");
                richTextBox1.AppendText("\t" + "Lányok: " + women[x] + "\n");
                richTextBox1.AppendText("\n");
                x++;
            }
        }

        private void Simulation()
        {
            
            //A záróév mezőben megadott évig fut a szimuláció
            for (int year = 2005; year <= finalyearbox.Value; year++)
            {
                // Végigmegyünk az összes személyen
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
                men.Add(nbrOfMales);
                women.Add(nbrOfFemales);
                
            }
        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }
            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NbrOfChildren = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }
            return birthProbabilities;
        }

        public List<DeathProbability> GetDeathProbabilities (string csvpath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath,Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2])
                    });
                }
            }
            return deathProbabilities;
        }

        private void SimStep(int year, Person person)
        {
            if (!person.IsAlive) return;

            byte age = (byte)(year - person.BirthYear);

            double PDeath = (from x in DeathProbabilities
                             where x.Gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();
            //Meghalt a személy?
            if (rng.NextDouble() <= PDeath)
                person.IsAlive = false;

            if (person.IsAlive && person.Gender == Gender.Female)
            {
                double PBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();
                //Születik gyerek?
                if (rng.NextDouble() <= PBirth)
                {
                    Person ujszulott = new Person();
                    ujszulott.BirthYear = year;
                    ujszulott.NbrOfChildren = 0;
                    ujszulott.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(ujszulott);
                }
            }
        }
        //Szimuláció indítása
        private void Startbt_Click(object sender, EventArgs e)
        {
            Population = GetPopulation(pathtb.Text);
            BirthProbabilities = GetBirthProbabilities(@"C:\temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\temp\halál.csv");
            Simulation();
            DisplayResults();
        }

        private void Browsebt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.InitialDirectory = "c:\\temp";
                OFD.Filter = "CSV files (*.csv)|*.csv|All files|*.*";

                if (OFD.ShowDialog()==DialogResult.OK)
                {
                    pathtb.Text = OFD.FileName;
                }
            }
        }
    }
}
