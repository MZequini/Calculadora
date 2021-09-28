
namespace Calculadora {
    partial class Calculadora {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.gb_Options = new System.Windows.Forms.GroupBox();
            this.rbtn_Divisao = new System.Windows.Forms.RadioButton();
            this.rbtn_Multiplicacao = new System.Windows.Forms.RadioButton();
            this.rbtn_Subtracao = new System.Windows.Forms.RadioButton();
            this.rbtn_Soma = new System.Windows.Forms.RadioButton();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.lbl_txtOption = new System.Windows.Forms.Label();
            this.gb_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(46, 25);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(104, 22);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Número 1:";
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Location = new System.Drawing.Point(46, 72);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(104, 22);
            this.lbl_Num2.TabIndex = 1;
            this.lbl_Num2.Text = "Número 2:";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(181, 16);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 31);
            this.txt_Num1.TabIndex = 2;
            this.txt_Num1.TextChanged += new System.EventHandler(this.txt_Num1_TextChanged);
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(181, 63);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 31);
            this.txt_Num2.TabIndex = 3;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(46, 296);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(106, 22);
            this.lbl_Resultado.TabIndex = 4;
            this.lbl_Resultado.Text = "Resultado:";
            // 
            // gb_Options
            // 
            this.gb_Options.Controls.Add(this.rbtn_Divisao);
            this.gb_Options.Controls.Add(this.rbtn_Multiplicacao);
            this.gb_Options.Controls.Add(this.rbtn_Subtracao);
            this.gb_Options.Controls.Add(this.rbtn_Soma);
            this.gb_Options.Location = new System.Drawing.Point(327, 94);
            this.gb_Options.Name = "gb_Options";
            this.gb_Options.Size = new System.Drawing.Size(197, 176);
            this.gb_Options.TabIndex = 8;
            this.gb_Options.TabStop = false;
            // 
            // rbtn_Divisao
            // 
            this.rbtn_Divisao.AutoSize = true;
            this.rbtn_Divisao.Location = new System.Drawing.Point(26, 139);
            this.rbtn_Divisao.Name = "rbtn_Divisao";
            this.rbtn_Divisao.Size = new System.Drawing.Size(93, 26);
            this.rbtn_Divisao.TabIndex = 3;
            this.rbtn_Divisao.TabStop = true;
            this.rbtn_Divisao.Text = "Divisão";
            this.rbtn_Divisao.UseVisualStyleBackColor = true;
            this.rbtn_Divisao.CheckedChanged += new System.EventHandler(this.rbtn_Divisao_CheckedChanged);
            // 
            // rbtn_Multiplicacao
            // 
            this.rbtn_Multiplicacao.AutoSize = true;
            this.rbtn_Multiplicacao.Location = new System.Drawing.Point(26, 107);
            this.rbtn_Multiplicacao.Name = "rbtn_Multiplicacao";
            this.rbtn_Multiplicacao.Size = new System.Drawing.Size(151, 26);
            this.rbtn_Multiplicacao.TabIndex = 2;
            this.rbtn_Multiplicacao.TabStop = true;
            this.rbtn_Multiplicacao.Text = "Multiplicação";
            this.rbtn_Multiplicacao.UseVisualStyleBackColor = true;
            this.rbtn_Multiplicacao.CheckedChanged += new System.EventHandler(this.rbtn_Multiplicacao_CheckedChanged);
            // 
            // rbtn_Subtracao
            // 
            this.rbtn_Subtracao.AutoSize = true;
            this.rbtn_Subtracao.Location = new System.Drawing.Point(26, 75);
            this.rbtn_Subtracao.Name = "rbtn_Subtracao";
            this.rbtn_Subtracao.Size = new System.Drawing.Size(125, 26);
            this.rbtn_Subtracao.TabIndex = 1;
            this.rbtn_Subtracao.TabStop = true;
            this.rbtn_Subtracao.Text = "Subtração";
            this.rbtn_Subtracao.UseVisualStyleBackColor = true;
            this.rbtn_Subtracao.CheckedChanged += new System.EventHandler(this.rbtn_Subtracao_CheckedChanged);
            // 
            // rbtn_Soma
            // 
            this.rbtn_Soma.AutoSize = true;
            this.rbtn_Soma.Location = new System.Drawing.Point(26, 43);
            this.rbtn_Soma.Name = "rbtn_Soma";
            this.rbtn_Soma.Size = new System.Drawing.Size(96, 26);
            this.rbtn_Soma.TabIndex = 0;
            this.rbtn_Soma.TabStop = true;
            this.rbtn_Soma.Text = "Adição";
            this.rbtn_Soma.UseVisualStyleBackColor = true;
            this.rbtn_Soma.CheckedChanged += new System.EventHandler(this.rbtn_Soma_CheckedChanged);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(181, 287);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(100, 31);
            this.txt_Resultado.TabIndex = 9;
            this.txt_Resultado.TextChanged += new System.EventHandler(this.txt_Resultado_TextChanged);
            // 
            // lbl_txtOption
            // 
            this.lbl_txtOption.AutoSize = true;
            this.lbl_txtOption.Location = new System.Drawing.Point(46, 141);
            this.lbl_txtOption.Name = "lbl_txtOption";
            this.lbl_txtOption.Size = new System.Drawing.Size(260, 22);
            this.lbl_txtOption.TabIndex = 10;
            this.lbl_txtOption.Text = "Escolha a opção desejada:";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lbl_txtOption);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.gb_Options);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Num2);
            this.Controls.Add(this.lbl_Num1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.gb_Options.ResumeLayout(false);
            this.gb_Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.GroupBox gb_Options;
        private System.Windows.Forms.RadioButton rbtn_Divisao;
        private System.Windows.Forms.RadioButton rbtn_Multiplicacao;
        private System.Windows.Forms.RadioButton rbtn_Subtracao;
        private System.Windows.Forms.RadioButton rbtn_Soma;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Label lbl_txtOption;
    }
}

