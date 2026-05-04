using MiniExcelLibs;

namespace test.Services
{
    public class ExcelService
    {
        public List<T> ReadExcel<T>(string filePath) where T : class, new()
        {
            var data = MiniExcel.Query<T>(filePath).ToList();

            return data.Where(x => x != null).ToList();
        }
    }
}