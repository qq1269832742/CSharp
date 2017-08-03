using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public partial class ICard : Component
    {
        public ICard()
        {
            InitializeComponent();
        }

        public ICard(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
