﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boteco
{
    public partial class FormMenu : Form
    {
        public string Total
        {
            get { return lblTotalFunc.Text; }
            set { lblTotalFunc.Text = value; }
        }

        public FormMenu()
        {
            InitializeComponent();
            Boteco boteco = new Boteco();
            int total = boteco.NFuncionario();
            lblTotalFunc.Text = Convert.ToString(total);
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            var func = new FormFuncionario();
            func.Total = this;
            func.MdiParent = this.MdiParent;
            func.Show();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            var cli = new FormCliente();
            cli.MdiParent = this.MdiParent;
            cli.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pro = new FormProduto();
            pro.MdiParent = this.MdiParent;
            pro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
