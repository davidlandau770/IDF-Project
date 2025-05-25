using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIDF
{
    interface IOrganization
    {
        string DateOfEstablishment { get; }
        string CurrentCommander { get; }
    }
}
