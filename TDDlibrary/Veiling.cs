using System;

namespace TDDlibrary
{
    public class Veiling
    {
        //methods
        public void DoeBod(decimal bedrag)
        {
            if (bedrag>HoogsteBod)
            {
                hoogsteBodValue = bedrag;
            }
        }
        private decimal hoogsteBodValue;
        public decimal HoogsteBod
        {
            get
            {
                // throw new NotImplementedException();
                return hoogsteBodValue;
            }
            
        }

    }
}
