
namespace Banco
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAd = new System.Windows.Forms.Button();
            this.buttonConsultaTodos = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.radioProfessor = new System.Windows.Forms.RadioButton();
            this.radioMateria = new System.Windows.Forms.RadioButton();
            this.radioCurso = new System.Windows.Forms.RadioButton();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.labelSal = new System.Windows.Forms.Label();
            this.textSal = new System.Windows.Forms.TextBox();
            this.labelDds = new System.Windows.Forms.Label();
            this.boxDds = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.labelHorario = new System.Windows.Forms.Label();
            this.boxHorario = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.boxIdRes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAd
            // 
            resources.ApplyResources(this.buttonAd, "buttonAd");
            this.buttonAd.Name = "buttonAd";
            this.buttonAd.UseVisualStyleBackColor = true;
            this.buttonAd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonConsultaTodos
            // 
            resources.ApplyResources(this.buttonConsultaTodos, "buttonConsultaTodos");
            this.buttonConsultaTodos.Name = "buttonConsultaTodos";
            this.buttonConsultaTodos.UseVisualStyleBackColor = true;
            this.buttonConsultaTodos.Click += new System.EventHandler(this.buttonConsultaTodos_Click);
            // 
            // buttonDel
            // 
            resources.ApplyResources(this.buttonDel, "buttonDel");
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // radioProfessor
            // 
            resources.ApplyResources(this.radioProfessor, "radioProfessor");
            this.radioProfessor.Checked = true;
            this.radioProfessor.Name = "radioProfessor";
            this.radioProfessor.TabStop = true;
            this.radioProfessor.UseVisualStyleBackColor = true;
            this.radioProfessor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioMateria
            // 
            resources.ApplyResources(this.radioMateria, "radioMateria");
            this.radioMateria.Name = "radioMateria";
            this.radioMateria.UseVisualStyleBackColor = true;
            this.radioMateria.CheckedChanged += new System.EventHandler(this.radioMateria_CheckedChanged);
            // 
            // radioCurso
            // 
            resources.ApplyResources(this.radioCurso, "radioCurso");
            this.radioCurso.Name = "radioCurso";
            this.radioCurso.UseVisualStyleBackColor = true;
            this.radioCurso.CheckedChanged += new System.EventHandler(this.radioCurso_CheckedChanged);
            // 
            // buttonConsulta
            // 
            resources.ApplyResources(this.buttonConsulta, "buttonConsulta");
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textId
            // 
            resources.ApplyResources(this.textId, "textId");
            this.textId.Name = "textId";
            // 
            // labelSal
            // 
            resources.ApplyResources(this.labelSal, "labelSal");
            this.labelSal.Name = "labelSal";
            // 
            // textSal
            // 
            resources.ApplyResources(this.textSal, "textSal");
            this.textSal.Name = "textSal";
            // 
            // labelDds
            // 
            resources.ApplyResources(this.labelDds, "labelDds");
            this.labelDds.Name = "labelDds";
            // 
            // boxDds
            // 
            resources.ApplyResources(this.boxDds, "boxDds");
            this.boxDds.Name = "boxDds";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // boxNome
            // 
            resources.ApplyResources(this.boxNome, "boxNome");
            this.boxNome.Name = "boxNome";
            // 
            // labelHorario
            // 
            resources.ApplyResources(this.labelHorario, "labelHorario");
            this.labelHorario.Name = "labelHorario";
            // 
            // boxHorario
            // 
            resources.ApplyResources(this.boxHorario, "boxHorario");
            this.boxHorario.Name = "boxHorario";
            // 
            // labelId
            // 
            resources.ApplyResources(this.labelId, "labelId");
            this.labelId.Name = "labelId";
            // 
            // boxIdRes
            // 
            resources.ApplyResources(this.boxIdRes, "boxIdRes");
            this.boxIdRes.Name = "boxIdRes";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.boxIdRes);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.boxHorario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.labelDds);
            this.Controls.Add(this.boxDds);
            this.Controls.Add(this.labelSal);
            this.Controls.Add(this.textSal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.radioCurso);
            this.Controls.Add(this.radioMateria);
            this.Controls.Add(this.radioProfessor);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonConsultaTodos);
            this.Controls.Add(this.buttonAd);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAd;
        private System.Windows.Forms.Button buttonConsultaTodos;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.RadioButton radioProfessor;
        private System.Windows.Forms.RadioButton radioMateria;
        private System.Windows.Forms.RadioButton radioCurso;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label labelSal;
        private System.Windows.Forms.TextBox textSal;
        private System.Windows.Forms.Label labelDds;
        private System.Windows.Forms.TextBox boxDds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.TextBox boxHorario;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox boxIdRes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

