namespace AtividadeEstacionamento
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnRetirar = new System.Windows.Forms.Button();
			this.btnEstacionar = new System.Windows.Forms.Button();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listVeiculos = new System.Windows.Forms.ListView();
			this.lblVeiculos = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnFechar);
			this.groupBox1.Controls.Add(this.btnRetirar);
			this.groupBox1.Controls.Add(this.btnEstacionar);
			this.groupBox1.Controls.Add(this.txtPlaca);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.groupBox1.Location = new System.Drawing.Point(47, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 296);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operações";
			// 
			// btnFechar
			// 
			this.btnFechar.Location = new System.Drawing.Point(60, 211);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(179, 35);
			this.btnFechar.TabIndex = 4;
			this.btnFechar.Text = "Fechar o Estacionamento";
			this.btnFechar.UseVisualStyleBackColor = true;
			// 
			// btnRetirar
			// 
			this.btnRetirar.Location = new System.Drawing.Point(163, 146);
			this.btnRetirar.Name = "btnRetirar";
			this.btnRetirar.Size = new System.Drawing.Size(110, 35);
			this.btnRetirar.TabIndex = 3;
			this.btnRetirar.Text = "Retirar";
			this.btnRetirar.UseVisualStyleBackColor = true;
			this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
			// 
			// btnEstacionar
			// 
			this.btnEstacionar.Location = new System.Drawing.Point(31, 146);
			this.btnEstacionar.Name = "btnEstacionar";
			this.btnEstacionar.Size = new System.Drawing.Size(110, 35);
			this.btnEstacionar.TabIndex = 2;
			this.btnEstacionar.Text = "Estacionar";
			this.btnEstacionar.UseVisualStyleBackColor = true;
			this.btnEstacionar.Click += new System.EventHandler(this.btnEstacionar_Click);
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(31, 101);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(242, 25);
			this.txtPlaca.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite a Placa";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listVeiculos);
			this.groupBox2.Controls.Add(this.lblVeiculos);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.groupBox2.Location = new System.Drawing.Point(434, 43);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(316, 364);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listagem de Veículos";
			// 
			// listVeiculos
			// 
			this.listVeiculos.Location = new System.Drawing.Point(30, 82);
			this.listVeiculos.Name = "listVeiculos";
			this.listVeiculos.Size = new System.Drawing.Size(255, 244);
			this.listVeiculos.TabIndex = 7;
			this.listVeiculos.UseCompatibleStateImageBehavior = false;
			this.listVeiculos.View = System.Windows.Forms.View.List;
			this.listVeiculos.SelectedIndexChanged += new System.EventHandler(this.listVeiculos_SelectedIndexChanged);
			// 
			// lblVeiculos
			// 
			this.lblVeiculos.AutoSize = true;
			this.lblVeiculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblVeiculos.Location = new System.Drawing.Point(83, 42);
			this.lblVeiculos.Name = "lblVeiculos";
			this.lblVeiculos.Size = new System.Drawing.Size(15, 17);
			this.lblVeiculos.TabIndex = 6;
			this.lblVeiculos.Text = "0";
			this.lblVeiculos.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Veículos:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 468);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox1;
		private Button btnFechar;
		private Button btnRetirar;
		private Button btnEstacionar;
		private TextBox txtPlaca;
		private Label label1;
		private GroupBox groupBox2;
		private Label lblVeiculos;
		private Label label2;
		private ListView listVeiculos;
	}
}