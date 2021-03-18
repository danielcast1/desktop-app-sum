using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tex;

namespace APPOperacion
{
    public partial class Form1 : Form
    {
        private List<float> _notes = new List<float>();
        public Form1()
        {
            InitializeComponent();
        }

         private void addNote(float note) {
            _notes.Add(note);
        } 
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //instanciar la logica de negocio 
            Operacion objO = new Operacion();

            try
            {

                addNote(float.Parse(txt1.Text));
                addNote(float.Parse(txt2.Text));
                addNote(float.Parse(txt3.Text));
                addNote(float.Parse(txt4.Text));

                objO.setNotas=_notes;

                if (objO.calcular())
                {
                    txtsuma.Text = objO.getSum.ToString();
                    return;
                }
                MessageBox.Show(objO.getError);
                _notes.Clear();
                objO = null;
            }
            catch(Exception _)
            {
                txtsuma.Text = "No puede ser Texto";
            }   
        }

    }
}
