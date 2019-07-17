/*
 * Created by SharpDevelop.
 * User: USRGAM
 * Date: 26/06/2019
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IntroductionFiles
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvLogs;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn log;
		private System.Windows.Forms.Button btnanadirlog;
		private System.Windows.Forms.Button btnLeerDirectorio;
		private System.Windows.Forms.TextBox txtLeerDirectorio;
		private System.Windows.Forms.TextBox txbLeerDirectorio;
		private System.Windows.Forms.Button btnListarDirectorio;
		private System.Windows.Forms.Button btnCrearArchivo;
		private System.Windows.Forms.TextBox txtCrearArchivo;
		private System.Windows.Forms.Button btnCrearDirectorio;
		private System.Windows.Forms.TextBox txbCrearDirectorio;
		private System.Windows.Forms.Button btnCopiarDirectorio;
		private System.Windows.Forms.TextBox txbDirOrigen;
		private System.Windows.Forms.TextBox txbDirDestino;
		private System.Windows.Forms.TextBox txbStreamW;
		private System.Windows.Forms.Button btnStreamW;
		private System.Windows.Forms.Button btnStreamR;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnanadirlog = new System.Windows.Forms.Button();
            this.btnLeerDirectorio = new System.Windows.Forms.Button();
            this.txtLeerDirectorio = new System.Windows.Forms.TextBox();
            this.txbLeerDirectorio = new System.Windows.Forms.TextBox();
            this.btnListarDirectorio = new System.Windows.Forms.Button();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtCrearArchivo = new System.Windows.Forms.TextBox();
            this.btnCrearDirectorio = new System.Windows.Forms.Button();
            this.txbCrearDirectorio = new System.Windows.Forms.TextBox();
            this.btnCopiarDirectorio = new System.Windows.Forms.Button();
            this.txbDirOrigen = new System.Windows.Forms.TextBox();
            this.txbDirDestino = new System.Windows.Forms.TextBox();
            this.txbStreamW = new System.Windows.Forms.TextBox();
            this.btnStreamW = new System.Windows.Forms.Button();
            this.btnStreamR = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbDirArchivo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbAnios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbType = new System.Windows.Forms.TextBox();
            this.btnOrdenarArregloBS = new System.Windows.Forms.Button();
            this.txbarrreglo = new System.Windows.Forms.TextBox();
            this.btnOdenarArregloSs = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.log});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogs.Location = new System.Drawing.Point(23, 79);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(943, 203);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLogsCellContentClick);
            this.dgvLogs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo Logo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // log
            // 
            this.log.HeaderText = "Descripcion";
            this.log.Name = "log";
            this.log.ReadOnly = true;
            // 
            // btnanadirlog
            // 
            this.btnanadirlog.Location = new System.Drawing.Point(12, 304);
            this.btnanadirlog.Name = "btnanadirlog";
            this.btnanadirlog.Size = new System.Drawing.Size(97, 23);
            this.btnanadirlog.TabIndex = 1;
            this.btnanadirlog.Text = "Anadir Log";
            this.btnanadirlog.UseVisualStyleBackColor = true;
            this.btnanadirlog.Click += new System.EventHandler(this.BtnanadirlogClick);
            // 
            // btnLeerDirectorio
            // 
            this.btnLeerDirectorio.Location = new System.Drawing.Point(36, 38);
            this.btnLeerDirectorio.Name = "btnLeerDirectorio";
            this.btnLeerDirectorio.Size = new System.Drawing.Size(133, 23);
            this.btnLeerDirectorio.TabIndex = 2;
            this.btnLeerDirectorio.Text = "Leer Directorio";
            this.btnLeerDirectorio.UseVisualStyleBackColor = true;
            this.btnLeerDirectorio.Click += new System.EventHandler(this.BtnLeerDirectorioClick);
            // 
            // txtLeerDirectorio
            // 
            this.txtLeerDirectorio.Location = new System.Drawing.Point(12, 12);
            this.txtLeerDirectorio.Name = "txtLeerDirectorio";
            this.txtLeerDirectorio.Size = new System.Drawing.Size(237, 20);
            this.txtLeerDirectorio.TabIndex = 3;
            // 
            // txbLeerDirectorio
            // 
            this.txbLeerDirectorio.Location = new System.Drawing.Point(269, 12);
            this.txbLeerDirectorio.Name = "txbLeerDirectorio";
            this.txbLeerDirectorio.Size = new System.Drawing.Size(216, 20);
            this.txbLeerDirectorio.TabIndex = 4;
            // 
            // btnListarDirectorio
            // 
            this.btnListarDirectorio.Location = new System.Drawing.Point(325, 38);
            this.btnListarDirectorio.Name = "btnListarDirectorio";
            this.btnListarDirectorio.Size = new System.Drawing.Size(75, 23);
            this.btnListarDirectorio.TabIndex = 5;
            this.btnListarDirectorio.Text = "Listar Directorio";
            this.btnListarDirectorio.UseVisualStyleBackColor = true;
            this.btnListarDirectorio.Click += new System.EventHandler(this.BtnListarDirectorioClick);
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.Location = new System.Drawing.Point(526, 38);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(129, 23);
            this.btnCrearArchivo.TabIndex = 6;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = true;
            this.btnCrearArchivo.Click += new System.EventHandler(this.BtnCrearArchivoClick);
            // 
            // txtCrearArchivo
            // 
            this.txtCrearArchivo.Location = new System.Drawing.Point(511, 12);
            this.txtCrearArchivo.Name = "txtCrearArchivo";
            this.txtCrearArchivo.Size = new System.Drawing.Size(160, 20);
            this.txtCrearArchivo.TabIndex = 7;
            // 
            // btnCrearDirectorio
            // 
            this.btnCrearDirectorio.Location = new System.Drawing.Point(321, 391);
            this.btnCrearDirectorio.Name = "btnCrearDirectorio";
            this.btnCrearDirectorio.Size = new System.Drawing.Size(164, 23);
            this.btnCrearDirectorio.TabIndex = 8;
            this.btnCrearDirectorio.Text = "Crear Directorio";
            this.btnCrearDirectorio.UseVisualStyleBackColor = true;
            this.btnCrearDirectorio.Click += new System.EventHandler(this.BtnCrearDirectorioClick);
            // 
            // txbCrearDirectorio
            // 
            this.txbCrearDirectorio.Location = new System.Drawing.Point(325, 365);
            this.txbCrearDirectorio.Name = "txbCrearDirectorio";
            this.txbCrearDirectorio.Size = new System.Drawing.Size(160, 20);
            this.txbCrearDirectorio.TabIndex = 9;
            // 
            // btnCopiarDirectorio
            // 
            this.btnCopiarDirectorio.Location = new System.Drawing.Point(211, 333);
            this.btnCopiarDirectorio.Name = "btnCopiarDirectorio";
            this.btnCopiarDirectorio.Size = new System.Drawing.Size(115, 23);
            this.btnCopiarDirectorio.TabIndex = 10;
            this.btnCopiarDirectorio.Text = "Copiar Directorio";
            this.btnCopiarDirectorio.UseVisualStyleBackColor = true;
            this.btnCopiarDirectorio.Click += new System.EventHandler(this.BtnCopiarDirectorioClick);
            // 
            // txbDirOrigen
            // 
            this.txbDirOrigen.Location = new System.Drawing.Point(124, 307);
            this.txbDirOrigen.Name = "txbDirOrigen";
            this.txbDirOrigen.Size = new System.Drawing.Size(139, 20);
            this.txbDirOrigen.TabIndex = 11;
            // 
            // txbDirDestino
            // 
            this.txbDirDestino.Location = new System.Drawing.Point(269, 307);
            this.txbDirDestino.Name = "txbDirDestino";
            this.txbDirDestino.Size = new System.Drawing.Size(154, 20);
            this.txbDirDestino.TabIndex = 12;
            // 
            // txbStreamW
            // 
            this.txbStreamW.Location = new System.Drawing.Point(475, 305);
            this.txbStreamW.Name = "txbStreamW";
            this.txbStreamW.Size = new System.Drawing.Size(100, 20);
            this.txbStreamW.TabIndex = 13;
            // 
            // btnStreamW
            // 
            this.btnStreamW.Location = new System.Drawing.Point(593, 303);
            this.btnStreamW.Name = "btnStreamW";
            this.btnStreamW.Size = new System.Drawing.Size(111, 23);
            this.btnStreamW.TabIndex = 14;
            this.btnStreamW.Text = "Escribir Texto";
            this.btnStreamW.UseVisualStyleBackColor = true;
            this.btnStreamW.Click += new System.EventHandler(this.BtnStreamWClick);
            // 
            // btnStreamR
            // 
            this.btnStreamR.Location = new System.Drawing.Point(593, 331);
            this.btnStreamR.Name = "btnStreamR";
            this.btnStreamR.Size = new System.Drawing.Size(111, 23);
            this.btnStreamR.TabIndex = 15;
            this.btnStreamR.Text = "Stream R";
            this.btnStreamR.UseVisualStyleBackColor = true;
            this.btnStreamR.Click += new System.EventHandler(this.BtnStreamRClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(727, 333);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Abrir";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbDirArchivo
            // 
            this.txbDirArchivo.Location = new System.Drawing.Point(727, 304);
            this.txbDirArchivo.Name = "txbDirArchivo";
            this.txbDirArchivo.Size = new System.Drawing.Size(85, 20);
            this.txbDirArchivo.TabIndex = 17;
            this.txbDirArchivo.TextChanged += new System.EventHandler(this.txbDirArchivo_TextChanged);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(882, 315);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 18;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(882, 339);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 19;
            // 
            // txbAnios
            // 
            this.txbAnios.Location = new System.Drawing.Point(882, 365);
            this.txbAnios.Name = "txbAnios";
            this.txbAnios.Size = new System.Drawing.Size(100, 20);
            this.txbAnios.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cita1:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cita 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cita3:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(770, 391);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(848, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(929, 391);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(836, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Libreria";
            // 
            // txbType
            // 
            this.txbType.Location = new System.Drawing.Point(883, 289);
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(100, 20);
            this.txbType.TabIndex = 28;
            // 
            // btnOrdenarArregloBS
            // 
            this.btnOrdenarArregloBS.Location = new System.Drawing.Point(691, 38);
            this.btnOrdenarArregloBS.Name = "btnOrdenarArregloBS";
            this.btnOrdenarArregloBS.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenarArregloBS.TabIndex = 29;
            this.btnOrdenarArregloBS.Text = "Ordenar BS";
            this.btnOrdenarArregloBS.UseVisualStyleBackColor = true;
            this.btnOrdenarArregloBS.Click += new System.EventHandler(this.btnOrdenarArregloBS_Click);
            // 
            // txbarrreglo
            // 
            this.txbarrreglo.Location = new System.Drawing.Point(691, 12);
            this.txbarrreglo.Name = "txbarrreglo";
            this.txbarrreglo.Size = new System.Drawing.Size(154, 20);
            this.txbarrreglo.TabIndex = 30;
            // 
            // btnOdenarArregloSs
            // 
            this.btnOdenarArregloSs.Location = new System.Drawing.Point(772, 38);
            this.btnOdenarArregloSs.Name = "btnOdenarArregloSs";
            this.btnOdenarArregloSs.Size = new System.Drawing.Size(75, 23);
            this.btnOdenarArregloSs.TabIndex = 31;
            this.btnOdenarArregloSs.Text = "Select Sort";
            this.btnOdenarArregloSs.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(865, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(73, 23);
            this.BtnBuscar.TabIndex = 32;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxbBuscar
            // 
            this.TxbBuscar.Location = new System.Drawing.Point(865, 12);
            this.TxbBuscar.Name = "TxbBuscar";
            this.TxbBuscar.Size = new System.Drawing.Size(73, 20);
            this.TxbBuscar.TabIndex = 33;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1010, 451);
            this.Controls.Add(this.TxbBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.btnOdenarArregloSs);
            this.Controls.Add(this.txbarrreglo);
            this.Controls.Add(this.btnOrdenarArregloBS);
            this.Controls.Add(this.txbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAnios);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDirArchivo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnStreamR);
            this.Controls.Add(this.btnStreamW);
            this.Controls.Add(this.txbStreamW);
            this.Controls.Add(this.txbDirDestino);
            this.Controls.Add(this.txbDirOrigen);
            this.Controls.Add(this.btnCopiarDirectorio);
            this.Controls.Add(this.txbCrearDirectorio);
            this.Controls.Add(this.btnCrearDirectorio);
            this.Controls.Add(this.txtCrearArchivo);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.btnListarDirectorio);
            this.Controls.Add(this.txbLeerDirectorio);
            this.Controls.Add(this.txtLeerDirectorio);
            this.Controls.Add(this.btnLeerDirectorio);
            this.Controls.Add(this.btnanadirlog);
            this.Controls.Add(this.dgvLogs);
            this.Name = "MainForm";
            this.Text = "IntroductionFiles";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.Click += new System.EventHandler(this.BtnanadirlogClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbDirArchivo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbAnios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Button btnOrdenarArregloBS;
        private System.Windows.Forms.TextBox txbarrreglo;
        private System.Windows.Forms.Button btnOdenarArregloSs;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxbBuscar;
    }
	}

