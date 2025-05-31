using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezunbilgisistemi_proje_ödevi_
{
    public partial class frmisbilgileri : Component
    {
        public frmisbilgileri()
        {
            InitializeComponent();
        }

        public frmisbilgileri(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
