namespace AMcore.Helpers
{
    public static class WebClient
    {
        public static async Task<string> WebGetAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException($"\"{nameof(url)}\" не может быть пустым или содержать только пробел.", nameof(url));
            return await WebGetInternalAsync(url);
        }
        private static async Task<string> WebGetInternalAsync(string url)
        {
            HttpClient client = new();
            client.Timeout = TimeSpan.FromSeconds(10);
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (TaskCanceledException)
            {
                throw new TaskCanceledException($"Запрос был отменен, так как истекло время ожидания {client.Timeout.Seconds} секунды.");
            }
        }
    }
}
