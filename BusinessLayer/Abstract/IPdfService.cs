using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPdfService
    {
        Task<Pdf> CreatePaper(Pdf pdf);

    }
}
