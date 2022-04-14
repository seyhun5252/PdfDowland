using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class PdfRepository : IPdfRepository
    {
        public async Task<Pdf> CreatePaper(Pdf pdf)
        {
            using (var pdfDbContext= new PdfDbContext())
            {
                pdfDbContext.Pdfs.Add(pdf);
                await pdfDbContext.SaveChangesAsync();
                return pdf;
            }
        }
    }
}
