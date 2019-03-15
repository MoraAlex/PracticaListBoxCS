using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoPirataSpotify
{
    public partial class Form1 : Form
    {
        static Metadata metadata1 = new Metadata("Alejandro Fernandez", "Prometi olvidarte", 1994, "Balada");
        static Metadata metadata2 = new Metadata("Daddy Yankee", "La luz del ritmo", 2005, "Reggaeton");
        static Metadata metadata3 = new Metadata("Daddy Yankee", "Perreo 2015", 2005, "Reggaeton");
        static Metadata metadata4 = new Metadata("Grupo Marrano", "Mas marrano que nunca", 2007, "Balada");
        static Metadata metadata5 = new Metadata("Grupo Marrano", "El primer lechon", 2000, "Balada");
        static Metadata metadata6 = new Metadata("Arrolladora banda el limon", "El ultimo adios", 1998, "Banda");
        static Metadata metadata7 = new Metadata("Gera MXM", "Los pajaros cumbia", 2008, "Rap");
        static Metadata metadata8 = new Metadata("Aleman", "Siempre cholos", 2014, "Rap");

        static Cancion cancion1 = new Cancion("Le baje las estrellas", "5:15", metadata1);
        static Cancion cancion8 = new Cancion("Canta corazon", "3:55", metadata1);
        static Cancion cancion9 = new Cancion("Niña", "3:42", metadata1);
        static Cancion cancion10 = new Cancion("Rienda suelta", "3:09", metadata1);
        static Cancion cancion11 = new Cancion("Cascos ligeros", "3:01", metadata1);
        static Cancion cancion12 = new Cancion("Tu y yo", "3:15", metadata1);
        static Cancion cancion2 = new Cancion("Despacito", "5:15", metadata2);
        static Cancion cancion3 = new Cancion("Gasolina", "4:05", metadata2);
        static Cancion cancion4 = new Cancion("Impacto", "2:40", metadata2);
        static Cancion cancion5 = new Cancion("Llegamos a la disco", "6:23", metadata2);
        static Cancion cancion6 = new Cancion("Pose", "3:30", metadata3);
        static Cancion cancion7 = new Cancion("Perro intenso", "2:55", metadata3);
        static Cancion cancion13 = new Cancion("El ansioso", "2:15", metadata4);
        static Cancion cancion14 = new Cancion("Porno taquero", "2:30", metadata4);
        static Cancion cancion15 = new Cancion("Por tus pujidos nos cacharon", "2:22", metadata5);
        static Cancion cancion16 = new Cancion("Que paso", "5:55", metadata5);
        static Cancion cancion17 = new Cancion("Cuelgale", "3:00", metadata6);
        static Cancion cancion18 = new Cancion("Gol", "4:45", metadata6);
        static Cancion cancion19 = new Cancion("Procuro olvidarte", "6:15", metadata6);
        static Cancion cancion20 = new Cancion("Llamale", "1:15", metadata6);
        static Cancion cancion21 = new Cancion("Procuro recordarte", "2:23", metadata6);
        static Cancion cancion22 = new Cancion("La suata", "4:42", metadata6);
        static Cancion cancion23 = new Cancion("La calle es mi vida", "4:24", metadata7);
        static Cancion cancion24 = new Cancion("Mi amigo el balon", "7:39", metadata7);
        static Cancion cancion25 = new Cancion("Ni tu ni nadie", "2:37", metadata7);
        static Cancion cancion26 = new Cancion("Somos los mismos", "5:15", metadata7);
        static Cancion cancion27 = new Cancion("El rucon", "3:00", metadata8);
        static Cancion cancion28 = new Cancion("Solo ella", "3:05", metadata8);
        static Cancion cancion29 = new Cancion("Marijuana", "4:10", metadata8);
        static Cancion cancion30 = new Cancion("Eres", "3:34", metadata8);

        static List<Cancion> canciones = new List<Cancion>();
        
        
        public Form1()
        {

            InitializeComponent();

            listBox_canciones.Items.Add(cancion1.nombre + "---" + cancion1.duracion);
            listBox_canciones.Items.Add(cancion2.nombre + "---" + cancion2.duracion);
            listBox_canciones.Items.Add(cancion3.nombre + "---" + cancion3.duracion);
            listBox_canciones.Items.Add(cancion4.nombre + "---" + cancion4.duracion);
            listBox_canciones.Items.Add(cancion5.nombre + "---" + cancion5.duracion);
            listBox_canciones.Items.Add(cancion6.nombre + "---" + cancion6.duracion);
            listBox_canciones.Items.Add(cancion7.nombre + "---" + cancion7.duracion);
            listBox_canciones.Items.Add(cancion8.nombre + "---" + cancion8.duracion);
            listBox_canciones.Items.Add(cancion9.nombre + "---" + cancion9.duracion);
            listBox_canciones.Items.Add(cancion10.nombre + "---" + cancion10.duracion);
            listBox_canciones.Items.Add(cancion11.nombre + "---" + cancion11.duracion);
            listBox_canciones.Items.Add(cancion12.nombre + "---" + cancion12.duracion);
            listBox_canciones.Items.Add(cancion13.nombre + "---" + cancion13.duracion);
            listBox_canciones.Items.Add(cancion14.nombre + "---" + cancion14.duracion);
            listBox_canciones.Items.Add(cancion15.nombre + "---" + cancion15.duracion);
            listBox_canciones.Items.Add(cancion16.nombre + "---" + cancion16.duracion);
            listBox_canciones.Items.Add(cancion17.nombre + "---" + cancion17.duracion);
            listBox_canciones.Items.Add(cancion18.nombre + "---" + cancion18.duracion);
            listBox_canciones.Items.Add(cancion19.nombre + "---" + cancion19.duracion);
            listBox_canciones.Items.Add(cancion20.nombre + "---" + cancion20.duracion);
            listBox_canciones.Items.Add(cancion21.nombre + "---" + cancion21.duracion);
            listBox_canciones.Items.Add(cancion22.nombre + "---" + cancion22.duracion);
            listBox_canciones.Items.Add(cancion23.nombre + "---" + cancion23.duracion);
            listBox_canciones.Items.Add(cancion24.nombre + "---" + cancion24.duracion);
            listBox_canciones.Items.Add(cancion25.nombre + "---" + cancion25.duracion);
            listBox_canciones.Items.Add(cancion26.nombre + "---" + cancion26.duracion);
            listBox_canciones.Items.Add(cancion27.nombre + "---" + cancion27.duracion);
            listBox_canciones.Items.Add(cancion28.nombre + "---" + cancion28.duracion);
            listBox_canciones.Items.Add(cancion29.nombre + "---" + cancion29.duracion);
            listBox_canciones.Items.Add(cancion30.nombre + "---" + cancion30.duracion);

            canciones.Add(cancion1);
            canciones.Add(cancion2);
            canciones.Add(cancion3);
            canciones.Add(cancion4);
            canciones.Add(cancion5);
            canciones.Add(cancion6);
            canciones.Add(cancion7);
            canciones.Add(cancion8);
            canciones.Add(cancion9);
            canciones.Add(cancion10);
            canciones.Add(cancion11);
            canciones.Add(cancion12);
            canciones.Add(cancion13);
            canciones.Add(cancion14);
            canciones.Add(cancion15);
            canciones.Add(cancion16);
            canciones.Add(cancion17);
            canciones.Add(cancion18);
            canciones.Add(cancion19);
            canciones.Add(cancion20);
            canciones.Add(cancion21);
            canciones.Add(cancion22);
            canciones.Add(cancion23);
            canciones.Add(cancion24);
            canciones.Add(cancion25);
            canciones.Add(cancion26);
            canciones.Add(cancion27);
            canciones.Add(cancion28);
            canciones.Add(cancion29);
            canciones.Add(cancion30);

            listBox_canciones.SelectedIndex = 0;

            if (listBox_canciones.SelectedIndex == 0)
                button_first.Enabled = false;
            else
                button_first.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_canciones.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_canciones.SelectedIndex == 0)
                button_first.Enabled = false;
            else
                button_first.Enabled = true;
            if (listBox_canciones.SelectedIndex == listBox_canciones.Items.Count - 1)
                button_last.Enabled = false;
            else
                button_last.Enabled = true;

            string nombreCancion = "";
            string duracionCancion = "";
            //int bandera = 0;
            int firstIndex = listBox_canciones.SelectedItem.ToString().IndexOf("-");
            int lastIndex = listBox_canciones.SelectedItem.ToString().LastIndexOf("-");
            nombreCancion = listBox_canciones.SelectedItem.ToString().Substring(0, firstIndex);
            //duracionCancion = listBox_canciones.SelectedItem.ToString().Substring(lastIndex, listBox_canciones.
            //    SelectedItem.ToString().Length);
            //Este for es para iterar entre la lista del listbox
            //los ifs se supone que setean las variables nombreCancion y
            //duracionCancion para buscar en la lista de canciones
            //generada previamente y asi poder acceder a su metadata
            //for(int i = 0; i < listBox_canciones.SelectedItem.ToString().Length; i++)
            //{
            //
            //    if(!listBox_canciones.SelectedItem.ToString().Substring(i).Equals("-") && bandera == 0)
            //    {
            //        nombreCancion.Insert(i, listBox_canciones.ToString().Substring(i));
            //        bandera = 0;
            //    }
            //    if (listBox_canciones.SelectedItem.ToString().Substring(i).Equals("-"))
            //        bandera = 1;
            //    if (listBox_canciones.SelectedItem.ToString().Substring(i) != "-" && bandera == 1)
            //    {
            //        duracionCancion.Insert(i, listBox_canciones.ToString().Substring(i));
            //        bandera = 0;
            //    }
            //        
            //}
            foreach(Cancion c in canciones)
            {
                if (c.nombre.Equals(nombreCancion))
                {
                    textBox_showMetadata.Text = c.metadata.ToString();
                    break;
                }
            }
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox_canciones.SelectedIndex != 0)
                listBox_canciones.SelectedIndex = listBox_canciones.SelectedIndex - 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox_canciones.SelectedIndex < listBox_canciones.Items.Count- 1)
                listBox_canciones.SelectedIndex = listBox_canciones.SelectedIndex + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox_canciones.SelectedIndex = listBox_canciones.Items.Count - 1;
        }


    }
}
