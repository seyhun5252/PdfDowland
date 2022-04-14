using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPdfRepository
    {
        Task<Pdf> CreatePaper(Pdf pdf);

    }
}
