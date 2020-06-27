using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace Stock_Alram.WebCrawller
{
    class CrawllManager
    {
        Dictionary<string, CostSearcher> m_mapSubjects=new Dictionary<string, CostSearcher>();
        ChromeOptions options = new ChromeOptions();
        ChromeDriverService driverService = ChromeDriverService.CreateDefaultService();
        ChromeDriver driver = null;
        public CrawllManager()
        {
            //크롬 콘솔창 숨기기
            driverService.HideCommandPromptWindow = true;
            options.AddArgument("headless");
            driver = new ChromeDriver(driverService, options);
            driver.Navigate().GoToUrl("https://finance.naver.com/");

        }

        public bool Add_Sercher(string strSubject)
        {
            CostSearcher searcher = new CostSearcher(strSubject, driver);
            if (searcher.currCost != -1)
            {
                m_mapSubjects.Add(strSubject, searcher);
                return true;
            }
            searcher.Dispose();
            return false;
        }
        public int SubjectCost(string strSubject)
        {
            CostSearcher costSearcher=null;
            m_mapSubjects.TryGetValue(strSubject, out costSearcher);
            if (costSearcher == null)
                return -1;
            return m_mapSubjects[strSubject].currCost;
        }
        ~CrawllManager() {
            driverService.Dispose();
            driver.Close();
        }
    }
}