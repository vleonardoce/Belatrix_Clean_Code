using System;

namespace SOLID._04_Interface_Segregation
{
    public abstract class MultifunctionalPrinter
    {
        public virtual bool PrintContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public virtual bool ScanContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public virtual bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public virtual bool PhotoCopyContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public virtual bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
    }

    public class HPLaserJet : MultifunctionalPrinter
    {
    }

    public class CannonMG2470 : MultifunctionalPrinter
    {
        public override bool PrintDuplexContent(string content)
        {
            return false;
        }
        public override bool FaxContent(string content)
        {
            return false;
        }
    }
}
