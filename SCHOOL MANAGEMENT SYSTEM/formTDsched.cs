using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    public partial class formTDsched : UserControl
    {
        internal Action<object, FormClosedEventArgs> FormClosed;
        internal TeacherDashboard MdiParent;
        internal FormStartPosition StartPosition;

        public formTDsched()
        {
            InitializeComponent();
        }

        internal object Activate()
        {
            throw new NotImplementedException();
        }
    }
}
