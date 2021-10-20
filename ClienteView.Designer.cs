
namespace JSON
{
    partial class ClienteView
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSerializar = new System.Windows.Forms.Button();
            this.btnDesserializar = new System.Windows.Forms.Button();
            this.dataGridViewListaClientes = new System.Windows.Forms.DataGridView();
            this.btnInserirDado = new System.Windows.Forms.Button();
            this.btnSerializarLista = new System.Windows.Forms.Button();
            this.btnDesserializarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(110, 39);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(189, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(110, 65);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(189, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // btnSerializar
            // 
            this.btnSerializar.Location = new System.Drawing.Point(110, 96);
            this.btnSerializar.Name = "btnSerializar";
            this.btnSerializar.Size = new System.Drawing.Size(75, 23);
            this.btnSerializar.TabIndex = 6;
            this.btnSerializar.Text = "Serializar";
            this.btnSerializar.UseVisualStyleBackColor = true;
            this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
            // 
            // btnDesserializar
            // 
            this.btnDesserializar.Location = new System.Drawing.Point(224, 96);
            this.btnDesserializar.Name = "btnDesserializar";
            this.btnDesserializar.Size = new System.Drawing.Size(75, 23);
            this.btnDesserializar.TabIndex = 7;
            this.btnDesserializar.Text = "Desserializar";
            this.btnDesserializar.UseVisualStyleBackColor = true;
            this.btnDesserializar.Click += new System.EventHandler(this.btnDesserializar_Click);
            // 
            // dataGridViewListaClientes
            // 
            this.dataGridViewListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaClientes.Location = new System.Drawing.Point(33, 186);
            this.dataGridViewListaClientes.Name = "dataGridViewListaClientes";
            this.dataGridViewListaClientes.Size = new System.Drawing.Size(411, 96);
            this.dataGridViewListaClientes.TabIndex = 8;
            // 
            // btnInserirDado
            // 
            this.btnInserirDado.Location = new System.Drawing.Point(34, 148);
            this.btnInserirDado.Name = "btnInserirDado";
            this.btnInserirDado.Size = new System.Drawing.Size(90, 23);
            this.btnInserirDado.TabIndex = 9;
            this.btnInserirDado.Text = "Inserir Dado";
            this.btnInserirDado.UseVisualStyleBackColor = true;
            this.btnInserirDado.Click += new System.EventHandler(this.btnInserirDado_Click);
            // 
            // btnSerializarLista
            // 
            this.btnSerializarLista.Location = new System.Drawing.Point(184, 148);
            this.btnSerializarLista.Name = "btnSerializarLista";
            this.btnSerializarLista.Size = new System.Drawing.Size(96, 23);
            this.btnSerializarLista.TabIndex = 10;
            this.btnSerializarLista.Text = "Serializar Lista";
            this.btnSerializarLista.UseVisualStyleBackColor = true;
            this.btnSerializarLista.Click += new System.EventHandler(this.btnSerializarLista_Click);
            // 
            // btnDesserializarLista
            // 
            this.btnDesserializarLista.Location = new System.Drawing.Point(337, 148);
            this.btnDesserializarLista.Name = "btnDesserializarLista";
            this.btnDesserializarLista.Size = new System.Drawing.Size(107, 23);
            this.btnDesserializarLista.TabIndex = 11;
            this.btnDesserializarLista.Text = "Desserializar Lista";
            this.btnDesserializarLista.UseVisualStyleBackColor = true;
            this.btnDesserializarLista.Click += new System.EventHandler(this.btnDesserializarLista_Click);
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 294);
            this.Controls.Add(this.btnDesserializarLista);
            this.Controls.Add(this.btnSerializarLista);
            this.Controls.Add(this.btnInserirDado);
            this.Controls.Add(this.dataGridViewListaClientes);
            this.Controls.Add(this.btnDesserializar);
            this.Controls.Add(this.btnSerializar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Name = "ClienteView";
            this.Text = "Aula Json";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSerializar;
        private System.Windows.Forms.Button btnDesserializar;
        private System.Windows.Forms.DataGridView dataGridViewListaClientes;
        private System.Windows.Forms.Button btnInserirDado;
        private System.Windows.Forms.Button btnSerializarLista;
        private System.Windows.Forms.Button btnDesserializarLista;
    }
}

