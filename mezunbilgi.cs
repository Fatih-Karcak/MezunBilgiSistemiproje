using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mezunbilgisistemi_proje_ödevi_
{
    public partial class mezunbilgi : Component
    {
        public mezunbilgi()
        {
            InitializeComponent();
        }

        public mezunbilgi(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
