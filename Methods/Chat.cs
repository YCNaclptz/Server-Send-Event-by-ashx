using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerSendEvent.Methods
{
    public class Chat
    {
        public static IEnumerable<string> GetChatStrings()
        {
            IEnumerable<string> sseDescription = new List<string>
            {
                "Server-Sent", "Events（SSE）", "是", "一種", "透過", "HTTP", "連線，", "由", "伺服器", "向", "瀏覽器", "推送", "資料的", "技術。", "以下", "是", "關於", "SSE", "的", "詳細", "說明：",
                "",
                "單向通訊：",
                "",
                "與", "WebSocket", "雙向通訊", "不同，", "SSE", "是", "單向通訊。", "一旦", "連線", "建立，", "伺服器", "可以", "持續", "向", "瀏覽器", "傳送", "資料，", "而", "瀏覽器", "無法", "主動", "向", "伺服器", "傳送", "資料。",
                "",
                "使用", "HTTP", "連線：",
                "",
                "SSE", "使用", "標準的", "HTTP", "連線，", "因此", "在", "建立", "連線", "和", "傳輸", "資料時，", "不需要", "額外的", "協議。", "這", "使得", "SSE", "更加", "容易", "與", "現有的", "HTTP", "基礎設施（如防火牆和代理伺服器）", "兼容。",
                "",
                "自動重連：",
                "",
                "當", "連線", "中斷時，", "瀏覽器", "會", "自動", "嘗試", "重新", "連接", "伺服器，", "這", "使得", "SSE", "在", "不穩定的", "網路環境下", "仍能", "保持", "穩定的", "數據", "傳輸。",
                "",
                "簡單易用：",
                "",
                "SSE", "相較於", "WebSocket", "更加", "簡單易用。", "開發者", "只需要", "設定", "伺服器的", "MIME", "類型為", "text/event-stream，", "並", "使用", "JavaScript", "的", "EventSource", "API", "來", "接收", "伺服器", "推送的", "資料。",
                "",
                "應用場景：",
                "",
                "SSE", "適用於", "需要", "頻繁", "更新", "資料的", "應用場景，", "例如", "即時", "通知、", "股票", "價格", "更新、", "新聞", "推送", "等。"
            };
            return sseDescription;
        }
    }
}