using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetIASalotti
{
    public partial class Form1 : Form
    {
        static public string initialPosition;
        static public string finalPosition;
        public Form1()
        {
            InitializeComponent();
        }

        private void resolvebtn_Click(object sender, EventArgs e)
        {
            //initialPosition = initialpositiontxtbx.Text;
            finalPosition = finalpositiontxtbx.Text;
            Graph g = new Graph();
            NodeLaby N0 = new NodeLaby(initialpositiontxtbx.Text);
            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

            // CA C'EST LE CODE DU TAQUIN, POUR QU'ON L'AIT SOUS LES YEUX

            //if (Lres.Count == 0)
            //{
            //    labelsolution.Text = "Pas de solution";
            //}
            //else
            //{
            //    labelsolution.Text = "Une solution a été trouvée";
            //    foreach (GenericNode N in Lres)
            //    {
            //        listBox1.Items.Add(N);
            //    }
            //    labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
            //    labelcountclosed.Text = "Nb noeuds des fermés : " + g.CountInClosedList().ToString();
            //    g.GetSearchTree(treeView1);
            }
        }
    }
