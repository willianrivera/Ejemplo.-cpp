/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
enum ColumnaLog {Tipo, Log};
namespace IntroductionFiles
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			DataGridViewTextBoxCell celdaTipo =
			(DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[0];
		    DataGridViewTextBoxCell celdaLog=
			(DataGridViewTextBoxCell)dgvLogs.Rows[e.RowIndex].Cells[1];
			
		    if(celdaTipo.Value != null)
			{
			 string tipo =	 celdaTipo.Value.ToString();
			 string log  =	 celdaLog.Value.ToString(); 
			 MessageBoxIcon icono;
			 if(tipo=="error")
			 {
			 	icono= MessageBoxIcon.Error;
			 }
			 else
			 {
			 	icono = MessageBoxIcon.Information;
			 }
			 
			 MessageBoxButtons botones= MessageBoxButtons.OK;
			 MessageBox.Show(log,tipo,botones,icono);
			}
			
       	}
		void BtnanadirlogClick(object sender, EventArgs e)
		{
			string log = "Prueba de Log ";
			string tipo = " info ";
			
			int posicionNuevoLog = dgvLogs.Rows.Add();
			
			
			dgvLogs.Rows[posicionNuevoLog].Cells[0].Value = tipo;
			dgvLogs.Rows[posicionNuevoLog].Cells[1].Value = log;
			// 1)Definir cadena de texto
			// 2) llamar data grid view
			// 3) Anadir fila
			// 4) 
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnLeerDirectorioClick(object sender, EventArgs e)
		{
			try
			{//ok
				string path = txtLeerDirectorio.Text;
				//Directory
				DirectoryInfo infoDirectorio = new DirectoryInfo(@path);
				string fechaCreacion = infoDirectorio.CreationTime.ToString();
				string nombreCompleto = infoDirectorio.FullName;
				string directorioPadre = infoDirectorio.Parent.ToString();
				string directorioRaiz = infoDirectorio.Root.ToString();
				
				EscribirLog ("info","Leyendo diractorio"+ fechaCreacion, dgvLogs);
                EscribirLog ("info", "Leyendo diractorio" + nombreCompleto, dgvLogs);
 				EscribirLog ("info", "Leyendo diractorio" + directorioRaiz, dgvLogs);                
			    EscribirLog ("info", "Leyendo diractorio" + directorioPadre, dgvLogs);
			    FileInfo[] archivosdelDirectorio = infoDirectorio.GetFiles();
			    foreach(FileInfo archivo in archivosdelDirectorio)
			    {
			    	EscribirLog("info","Archivo: "+archivo.CreationTime,dgvLogs);
			    	EscribirLog("info","Archivo: "+archivo.FullName,dgvLogs);
			    	EscribirLog("info","Archivo: "+archivo.Extension,dgvLogs);
			    	EscribirLog("info","Archivo: "+archivo.LastAccessTime,dgvLogs);
			    	EscribirLog("info","Archivo: "+archivo.IsReadOnly,dgvLogs);
			    }
			}
			catch(Exception error)//ERROR
			{
				EscribirLog ("error", error.ToString(), dgvLogs);
			}
		}
		void EscribirLog (string tipo, string log, DataGridView dgv){
		  int posicionNuevoLog = dgvLogs.Rows.Add();
						
		  dgvLogs.Rows[posicionNuevoLog].Cells[0].Value = tipo;
	 	  dgvLogs.Rows[posicionNuevoLog].Cells[1].Value = log;
	 	  
	 	  if(tipo == "error")
	 	  {
	 	  	dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor = Color.Red;
	 	  }
	 	  else
	 	  {
	 	  	dgv.Rows[posicionNuevoLog].Cells[0].Style.BackColor=Color.BlueViolet;
	 	  }
		  }
		void DgvLogsCellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		void BtnListarDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				string path= txbLeerDirectorio.Text;
				string[] arregloDirectorios = Directory.GetDirectories(@path);
				int numeroDirectorios = arregloDirectorios.Length;
				EscribirLog("info","Numero Directorios: " + numeroDirectorios.ToString(),dgvLogs);
				foreach(string directorio in arregloDirectorios)
				{
					EscribirLog("info", "Directorio: "+ directorio,dgvLogs);
				}
			    }
		    
		catch (Exception error)
			{
	         EscribirLog("error",error.ToString(),dgvLogs);
			}
		}
		void BtnCrearArchivoClick(object sender, EventArgs e)
		{
			try
			{
				string path= txtCrearArchivo.Text;				
				
				
				StreamWriter escritura = File.CreateText(@path);
				escritura.WriteLine("Nombre:");
				escritura.WriteLine("Edad:");
				escritura.WriteLine("Numero:");
				
				//Cerrar el archivo despues de usarlo
				escritura.Close();
				//StreamWriter escritura = File.(@path);
				
				/*using(StreamWriter escrituraDos = File.CreateText(@path))
				{
				escrituraDos.WriteLine("Hola Archivo");
				escrituraDos.WriteLine("Segunda Linea");
				escrituraDos.WriteLine("Tecera Linea");					
				}*/
					
				EscribirLog("info","Escritura Archivo : se estudio el archivo",dgvLogs);
			}
			catch(Exception error)
			{
				EscribirLog("error",error.ToString(),dgvLogs);
			}
		}
		void BtnCrearDirectorioClick(object sender, EventArgs e)
		{
			try
			{
				string path= txbCrearDirectorio.Text;
				Directory.CreateDirectory(@path);
				EscribirLog("info", "Crear Directorio: Se  creo el directorio" + path, dgvLogs);
			}
			catch(Exception error)
			{
				EscribirLog("error", error.ToString(),dgvLogs);
			}
		}

        private void copiarDirectorio(string origen, string destino, bool validacion)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(origen);
                if (!dir.Exists)
                {
                    string messageboxtext = "Directorio no Existe";

                    MessageBoxIcon icono = MessageBoxIcon.Error;
                    MessageBoxButtons Btn = MessageBoxButtons.OK;
                    MessageBox.Show(messageboxtext, "", Btn, icono);
                }
                DirectoryInfo[] dirs = dir.GetDirectories();
                if (!Directory.Exists(destino))
                {
                    Directory.CreateDirectory(destino);
                }
                FileInfo[] archivos = dir.GetFiles();
                foreach (FileInfo Archivo in archivos)
                {
                    string temppath = Path.Combine(destino, Archivo.Name);
                    Archivo.CopyTo(temppath, false);
                }
                if (validacion)
                {
                    foreach (DirectoryInfo subdirectorio in dirs)
                    {
                        string temppath = Path.Combine(destino, subdirectorio.Name);
                        copiarDirectorio(subdirectorio.FullName, temppath, validacion);
                    }
                }
            }
            catch (Exception error)
            {
                //string messageboxtext = "Directorio no Existe";

                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBoxButtons Btn = MessageBoxButtons.OK;
                MessageBox.Show(error.ToString(), "", Btn, icono);
            }
        }

        void BtnCopiarDirectorioClick(object sender, EventArgs e)
		{
			try{
				string origenDirectorio = txbDirOrigen.Text;
				string destinoDirectorio = txbDirDestino.Text;
				bool validaciondirectorio = Directory.Exists(@origenDirectorio);
				
                   // string[] directoriosOrigen = Directory.GetDirectories(@origenDirectorio);
                    //foreach(string dir in directoriosOrigen)
                    
                        copiarDirectorio(origenDirectorio,destinoDirectorio,true);
                    
                    //aRCHIVOS
                   // string[] archivosEncontrados = Directory.GetFiles(@origenDirectorio);
                    //FileCopy
                    /*foreach (string directorio in directoriosOrigen)
					{
						EscribirLog("info",directorio, dgvLogs );
						int inicioSubString= origenDirectorio.Length;
						int finSubString = directorio.Length;
						string  nombreDirectorio = directorio.ToString();
						EscribirLog("info", nombreDirectorio,dgvLogs);
					}*/
				
				
				}
				catch(Exception error)
				{
					EscribirLog("error",error.ToString(),dgvLogs);
				}
		}
		void BtnStreamWClick(object sender, EventArgs e)
		{
			String path = txbStreamW.Text;
			Stream writingStream = new FileStream(@path,FileMode.Create);
			try
			{
			  
			 if(writingStream.CanWrite)
			 {
			 	byte[] miNombreEnBytes = new byte[] {
			 	    68,65,86,73,68,32,65,71,85,73,82,82,69
			 };
			 	writingStream.Write(miNombreEnBytes, 0, miNombreEnBytes.Length);
			 	writingStream.WriteByte(33);
			    EscribirLog("info","Escribimos Archivo", dgvLogs);
			 }else
			 {
			 	EscribirLog("error","No puede escribir en el archivo", dgvLogs);
			 
			 }
			 writingStream.Close();
				
			}
			catch(Exception error)
			{
				EscribirLog("error",error.ToString(), dgvLogs);
			}
			finally{
				writingStream.Close();
			}
		}
		void BtnStreamRClick(object sender, EventArgs e)
		{
			string path = txbStreamW.Text;
			try
			{
				using(Stream readingStream = new FileStream(@path,FileMode.Open))
				{
				 byte[] arregloTemporal = new byte[3];
				 UTF8Encoding codification = new UTF8Encoding(true);//dEFINIR CODIFICACION DEL TEXTO EN NUESTRO BUFFER
				 //readingStream.Seek -> Moverse de Posiciones
				 int posicion;
				 while( (posicion= readingStream.Read(arregloTemporal, 0 ,arregloTemporal.Length)) > 0)
				 {
				 	string caracter = codification.GetString(arregloTemporal,0,arregloTemporal.Length);
	                EscribirLog("Info",  "Caracter: "+ caracter, dgvLogs);			 
				 }
			}
			
			}catch(Exception error)
			{
				EscribirLog("error",error.ToString(), dgvLogs);
			}
			
		}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string archivodir = txbDirArchivo.Text;
            bool validacion = File.Exists(@archivodir);
            if(validacion==true)
            {

                StreamReader reading = File.OpenText(@archivodir);
                string texto = reading.ReadToEnd();
                reading.Close();
                EscribirLog("Info", texto , dgvLogs);
            }
            else
            {
                EscribirLog("Error", "No existe el archivo, pero no se preocupe ya se creo su entrada", dgvLogs);
                StreamWriter nuevo = File.CreateText(@archivodir);
                nuevo.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string libreria = txbType.Text;
            
            string[] textoarray = File.ReadAllLines(@txbDirArchivo.Text);
            String Resultado = File.ReadAllText(@txbDirArchivo.Text);
            StreamWriter esribir = File.CreateText(@txbDirArchivo.Text);

            switch (libreria)
            {
                case "Musica":
                case "MUSICA":
                    string citas1 = "  Autor:" + txbNombre.Text + "  Duracion:" + txbNumero.Text + "  Instrumentos:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas1);
                    esribir.Close();
                    break;
                case "Videojuegos":
                case "VIDEOJUEGOS":
                    string citas2 = "  Juego:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Tamaño(MB)" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas2);
                    esribir.Close();
                    break;
                case "Libros":
                case "LIBROS":
                    string citas3 = "  Autor:" + txbNombre.Text + "  Edicion:" + txbNumero.Text + "  Año:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas3);
                    esribir.Close();
                    break;
                case "Peliculas":
                case "PELICULAS":
                    string citas4 = "  Titulo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Duracion(Hrs):" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas4);
                    esribir.Close();
                    break;
                case "Celulares":
                case "CELULARES":
                    string citas5 = "  Marca:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Año:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas5);
                    esribir.Close();
                    break;
                case "Equipos Futbol":
                case "EQUIPOS FUTBOL":
                    string citas6 = "  Equipo:" + txbNombre.Text + "  Campeonatos:" + txbNumero.Text + "  Años:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas6);
                    esribir.Close();
                    break;
                case "Cuentas Bancarias":
                case "CUENTAS BANCARIAS":
                    string citas7 = "  Nombre:" + txbNombre.Text + "  Numero de Cuenta" + txbNumero.Text + "  Money:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas7);
                    esribir.Close();
                    break;
                case "Automoviles":
                case "AUTOMOVILES":
                    string citas8 = "  Modelo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Recorrido(Km):" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas8);
                    esribir.Close();
                    break;
                case "Personajes Historicos":
                case "PERSONAJES HISTORICOS":
                    string citas9 = "  Nombre:" + txbNombre.Text + "  Año Nacimiento:" + txbNumero.Text + "  Años:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas9);
                    esribir.Close();
                    break;
                case "Atrasados":
                case "ATRASADOS":
                    string citas10 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas10);
                    esribir.Close();
                    break;
                case "Ausentes":
                case "AUSENTES":
                    string citas11 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas11);
                    esribir.Close();
                    break;
                case "Fugas":
                case "FUGAS":
                    string citas12 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas12);
                    esribir.Close();
                    break;
                case "Asistencias":
                case "ASISTENCIAS":
                    string citas13 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
                    esribir.WriteLine(Resultado + citas13);
                    esribir.Close();
                    break;
                default:
                    string TipoError = "Solamente tiene los tipos Musica,Libros, Atrasados,Equipos Futbol,Ausentes,Asistencias,Fugas, Personajes Historicos,Automoviles,Cuentas Bancarias,Celulares,Peliculas y Videojuegos";
                    MessageBoxButtons Icon = MessageBoxButtons.OK; 
                    MessageBox.Show(TipoError,"",Icon);
                    esribir.Close();
                    break;
            }

            //string cita2 = txbNumero.Text;
            //string cita3 = txbAnios.Text;
            //foreach (string palabras in textoarray)

            //string resultado = File.ReadAllText(@txbDirArchivo.Text);
            //EscribirLog("Info", resultado, dgvLogs);
            /**/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] resultado = File.ReadAllLines(@txbDirArchivo.Text);
            string citas1 = "  Autor:" + txbNombre.Text + "  Duracion:" + txbNumero.Text + "  Instrumentos:" + txbAnios.Text;
            string citas2 = "  Juego:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Tamaño(MB)" + txbAnios.Text;
            string citas3 = "  Autor:" + txbNombre.Text + "  Edicion:" + txbNumero.Text + "  Año:" + txbAnios.Text;
            string citas4 = "  Titulo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Duracion(Hrs):" + txbAnios.Text;
            string citas5 = "  Marca:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Año:" + txbAnios.Text;
            string citas6 = "  Equipo:" + txbNombre.Text + "  Campeonatos:" + txbNumero.Text + "  Años:" + txbAnios.Text;
            string citas7 = "  Nombre:" + txbNombre.Text + "  Numero de Cuenta" + txbNumero.Text + "  Money:" + txbAnios.Text;
            string citas8 = "  Modelo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Recorrido(Km):" + txbAnios.Text;
            string citas9 = "  Nombre:" + txbNombre.Text + "  Año Nacimiento:" + txbNumero.Text + "  Años:" + txbAnios.Text;
            string citas10 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas11 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas12 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas13 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;

            //String Resultado = File.ReadAllText(@txbDirArchivo.Text);
            StreamWriter esribir = File.CreateText(@txbDirArchivo.Text);
            foreach (string cadena in resultado)
            {
                if(cadena==citas1||cadena == citas2|| cadena == citas3||
                   cadena == citas4|| cadena == citas5|| cadena == citas6||
                   cadena == citas8|| cadena == citas9|| cadena == citas10||
                   cadena == citas11|| cadena == citas12|| cadena == citas13||
                   cadena==citas7)
                    
                {
                    esribir.WriteLine("");
                    continue;
                }

                esribir.WriteLine(cadena);
            }
            esribir.Close();
            String Resultado = File.ReadAllText(@txbDirArchivo.Text);
            EscribirLog("Info", Resultado, dgvLogs);
           
        }

        private void txbDirArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrdenarArregloBS_Click(object sender, EventArgs e)
        {

            try
            {
                {
                    string Numeros = txbarrreglo.Text;
                    string[] numerosseparacion = Numeros.Split(',');
                    int[] cantidades = new int[numerosseparacion.Length + 1];
                    int longitudArreglo = numerosseparacion.Length - 1;
                    int contador = 0;
                    foreach (string numero in numerosseparacion)
                    {

                        cantidades[contador] = Int32.Parse(numero);
                        EscribirLog("Info", cantidades[contador].ToString(), dgvLogs);
                        contador++;
                    }
                    for (int iPrimerelemento = 0;
                        iPrimerelemento < longitudArreglo;
                        iPrimerelemento++)
                    { // PRIMER FOR

                        for (int iSegundolemento = 0;
                            iSegundolemento < (longitudArreglo - iPrimerelemento);
                        iSegundolemento++)
                        {  // SEGUNDO FOR

                            int primerNumero = cantidades[iSegundolemento];
                            int segundoNumero = cantidades[iSegundolemento + 1];

                            if (primerNumero > segundoNumero)
                            {  // COMPARACION
                                int valorTemporal = primerNumero;
                                cantidades[iSegundolemento] = cantidades[iSegundolemento + 1];
                                cantidades[iSegundolemento + 1] = valorTemporal;

                            } //  TERMINA COMPARACION

                        }  // TERMINA SEGUNDO FOR


                    }// TERMINA PRIMER FOR

                    foreach (int elemento in cantidades)
                    {

                        EscribirLog("info", elemento.ToString(), dgvLogs);

                    }

                }
            }

            catch (Exception error)
            {
                EscribirLog("error", error.ToString(), dgvLogs);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string[] resultado = File.ReadAllLines(@txbDirArchivo.Text);
            string citas1 = "  Autor:" + txbNombre.Text + "  Duracion:" + txbNumero.Text + "  Instrumentos:" + txbAnios.Text;
            string citas2 = "  Juego:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Tamaño(MB)" + txbAnios.Text;
            string citas3 = "  Autor:" + txbNombre.Text + "  Edicion:" + txbNumero.Text + "  Año:" + txbAnios.Text;
            string citas4 = "  Titulo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Duracion(Hrs):" + txbAnios.Text;
            string citas5 = "  Marca:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Año:" + txbAnios.Text;
            string citas6 = "  Equipo:" + txbNombre.Text + "  Campeonatos:" + txbNumero.Text + "  Años:" + txbAnios.Text;
            string citas7 = "  Nombre:" + txbNombre.Text + "  Numero de Cuenta" + txbNumero.Text + "  Money:" + txbAnios.Text;
            string citas8 = "  Modelo:" + txbNombre.Text + "  Año:" + txbNumero.Text + "  Recorrido(Km):" + txbAnios.Text;
            string citas9 = "  Nombre:" + txbNombre.Text + "  Año Nacimiento:" + txbNumero.Text + "  Años:" + txbAnios.Text;
            string citas10 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas11 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas12 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;
            string citas13 = "  Nombre:" + txbNombre.Text + "  Numero:" + txbNumero.Text + "  Edad:" + txbAnios.Text;

            StreamWriter archivo = File.CreateText(@txbDirArchivo.Text);
            int numerodeLinea=1;
           
            int z = 0;
            foreach (string linea in resultado)
            {
               /* while (linea != citas1 & linea != citas2 &
                linea != citas3 & linea != citas4 &
                linea != citas5 & linea != citas6 &
                linea != citas7 & linea != citas8 &
                linea != citas9 & linea != citas10 &
                linea != citas11 & linea != citas12 &
                linea != citas13)
                {
                    numerodeLinea++;
                    string informacion = "Los Datos escritos no existe; verifique que escribio correctamente";
                    MessageBoxButtons icono = MessageBoxButtons.OK;
                    MessageBox.Show(informacion,"Adevertencia",icono);
                    continue;
                }*/
                /*if (linea == citas1 || linea == citas2 ||
                linea == citas3 || linea == citas4 ||
                linea == citas5 || linea == citas6 ||
                linea == citas7 || linea == citas8 ||
                linea == citas9 || linea == citas10 ||
                linea == citas11 || linea == citas12 ||
                linea == citas13)
                {
                    numerodeLinea++;
                    string informacion = "Los Datos escritos no existe; verifique que escribio correctamente";
                    MessageBoxButtons icono = MessageBoxButtons.OK;
                    MessageBox.Show(informacion, "Adevertencia", icono);
                    continue;
                }*/
                string[] citaespecifica = linea.Split(' ');
                string[] citaespecifica1 = citas1.Split(' ');

                int i = 0;

                foreach (string citasguardadas in citaespecifica)
                    {
                        if(citasguardadas == citaespecifica1[i])
                        {
                        if(i==2)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                        continue;
                        }
                    }
                    else
                    {
                        i++;
                        z++;
                        if (z<=2)
                        {
                            continue;

                        }
                        else
                        {
                            //resultado[numerodeLinea] = citas1;
                            EscribirLog("Info", citas1, dgvLogs);
                            for (int k = 0; k < resultado.Length; k++)
                            {
                                archivo.WriteLine(resultado[k]);

                            }
                            break;
                        }

                    }
                     
                    }
                numerodeLinea++;                                                
                //archivo.WriteLine(nuevaLinea);
                
            }
  
           if(z<3)
            {
                resultado[numerodeLinea] = citas1;
                EscribirLog("Info", citas1, dgvLogs);
                for (int k = 0; k < resultado.Length; k++)
                {
                    archivo.WriteLine(resultado[k]);

                }
            }
             
            archivo.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {





            }
            catch (Exception error)
            {
                EscribirLog("error", error.ToString(), dgvLogs);
            }




        }
    }
	}
  
   //[1,2,3]
//[0]=1
//[1]=2
// temporal=[0]=1
	
	
		



