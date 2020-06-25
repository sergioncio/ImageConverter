using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConversorImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap img;
        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = this.comboBox1.Text + "|" + this.comboBox1.Text;
            if (!this.comboBox1.Text.Equals(""))
            {
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Formato válido");
                    img = new Bitmap(ofd.FileName);
                    pictureBox2.Location = new System.Drawing.Point(0, 0);
                    pictureBox2.Name = "pictureBox1";
                    pictureBox2.Size = panel1.Size;
                    pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
                    panel1.Controls.Add(pictureBox1);
                    pictureBox2.Image = img;
                }
                else
                {
                    MessageBox.Show("El usuario ha cancelado o el formato no es el indicado.");
                }
            }
            else
            {
                MessageBox.Show("No ha introducido formato.");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = this.comboBox2.Text + "|" + this.comboBox2.Text;
            if (!this.comboBox2.Text.Equals(""))
            {
                if (comboBox2.Text != comboBox1.Text)
                {


                    DialogResult dr = sfd.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        if (this.comboBox2.Text.Equals("*.bmp"))
                        {
                            img.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            MessageBox.Show("El archivo se ha guardado correctamente");
                            pictureBox2.Image = null;
                            this.comboBox1.Text = null;
                            this.comboBox2.Text = null;
                        }
                        else if (this.comboBox2.Text.Equals("*.jpg"))
                        {
                            img.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            MessageBox.Show("El archivo se ha guardado correctamente");
                            pictureBox2.Image = null;
                            this.comboBox1.Text = null;
                            this.comboBox2.Text = null;
                        }
                        else if (this.comboBox2.Text.Equals("*.gif"))
                        {
                            img.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            MessageBox.Show("El archivo se ha guardado correctamente");
                            pictureBox2.Image = null;
                            this.comboBox1.Text = null;
                            this.comboBox2.Text = null;
                        }
                        else
                        {
                            img.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                            MessageBox.Show("El archivo se ha guardado correctamente");
                            pictureBox2.Image = null;
                            this.comboBox1.Text = null;
                            this.comboBox2.Text = null;
                        }

                    }
                    else
                    {
                        MessageBox.Show("El usuario ha cancelado la acción.");
                    }
                }
                else
                {
                    MessageBox.Show("El formato de entrada tiene que ser distinto que el de salida.");
                }
            }
            else
            {
                MessageBox.Show("No ha introducido formato.");
            }
        }
        String a = Console.ReadLine();
    }
}
