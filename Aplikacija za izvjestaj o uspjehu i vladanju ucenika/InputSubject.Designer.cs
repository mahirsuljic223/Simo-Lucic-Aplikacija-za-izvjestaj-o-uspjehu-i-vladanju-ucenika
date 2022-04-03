namespace Aplikacija_za_izvjestaj_o_uspjehu_i_vladanju_ucenika
{
    partial class InputSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputSubject));
            this.label2 = new System.Windows.Forms.Label();
            this.tb_professor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_subjectName = new System.Windows.Forms.TextBox();
            this.btn_inputSubject = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profesor";
            // 
            // tb_professor
            // 
            this.tb_professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_professor.Location = new System.Drawing.Point(132, 43);
            this.tb_professor.Name = "tb_professor";
            this.tb_professor.Size = new System.Drawing.Size(180, 23);
            this.tb_professor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naziv predmeta";
            // 
            // tb_subjectName
            // 
            this.tb_subjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subjectName.Location = new System.Drawing.Point(132, 14);
            this.tb_subjectName.Name = "tb_subjectName";
            this.tb_subjectName.Size = new System.Drawing.Size(180, 23);
            this.tb_subjectName.TabIndex = 0;
            // 
            // btn_inputSubject
            // 
            this.btn_inputSubject.BackColor = System.Drawing.Color.Lime;
            this.btn_inputSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_inputSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_inputSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inputSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inputSubject.Location = new System.Drawing.Point(16, 80);
            this.btn_inputSubject.Name = "btn_inputSubject";
            this.btn_inputSubject.Size = new System.Drawing.Size(296, 50);
            this.btn_inputSubject.TabIndex = 2;
            this.btn_inputSubject.Text = "Unesi predmet";
            this.btn_inputSubject.UseVisualStyleBackColor = false;
            this.btn_inputSubject.Click += new System.EventHandler(this.btn_inputSubject_Click);
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.Lime;
            this.btn_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(16, 136);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(145, 50);
            this.btn_return.TabIndex = 3;
            this.btn_return.Text = "Nazad";
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Lime;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(167, 136);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 50);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Izlaz";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // InputSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_professor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_subjectName);
            this.Controls.Add(this.btn_inputSubject);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos predmeta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputSubject_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_professor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_subjectName;
        private System.Windows.Forms.Button btn_inputSubject;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_exit;
    }
}