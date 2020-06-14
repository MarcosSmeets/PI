using System;

namespace PI
{
    class Vacina
    {
        private string paisOrig;
        private DateTime dataFab;
        private DateTime dataValid;

        public void setPaisOrig(string paisOrig)
        {
            this.paisOrig = paisOrig;
        }

        public string getPaisOrig()
        {
            return this.paisOrig;
        }

        public void setDataFab(DateTime dataFab)
        {
            this.dataFab = dataFab;
        }

        public DateTime getDataFab()
        {
            return this.dataFab;
        }

        public void setDataValid(DateTime dataValid)
        {
            this.dataValid = dataValid;
        }

        public DateTime getDataValid()
        {
            return this.dataValid;
        }

        public void showVacina()
        {
            Console.WriteLine("PaisOrig: " + getPaisOrig() + "dataFab: " + getDataFab() + "dataValid: " + getDataValid());
        }
    }
}