using System;

namespace PrintNumbers
{
    public class PrintNumbers
    {
        public TypeNumber ProcessNumber(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                return TypeNumber.AnsibleAustralia;
            }
            else if (i % 3 == 0)
            {
                return TypeNumber.Ansible;
            }
            else if (i % 5 == 0)
            {
                return TypeNumber.Australia;
            }

            return TypeNumber.None;
        }
    }

    public enum TypeNumber
    {
        AnsibleAustralia,
        Ansible,
        Australia,
        None
    }
}
