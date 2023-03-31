using System.Text.RegularExpressions;

namespace Editor.utils
{
    internal class ZnuNewsProvider : ITextDataProvider
    {
        private string url;

        public ZnuNewsProvider(string url = "https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr") 
        {
            this.url = url;
        }

        public string Load()
        {
            string titles = "";
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string document = content.ReadAsStringAsync().Result;
                        var news_titles = Regex.Matches(document, @"(?<=<h4><a\b[^>]*>)(.*?)(?=<\/a><\/h4>)")
                            .Cast<Match>()
                            .Select(m => m.Groups[1].Value)
                            .ToList();
                        foreach (var title in news_titles)
                        {
                            titles += title.ToString() + "\n";
                        }
                        return titles;
                    }
                }
            }
        }
    }
}
