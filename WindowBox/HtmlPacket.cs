namespace WindowBox
{
    public class HtmlPacket
    {
        public HtmlPacket(string content)
        {
            Content = content;
        }
        public string Content { get; private set; }

        public override string ToString()
        {
            return string.Format("Content: {0}", Content);
        }
    }
}