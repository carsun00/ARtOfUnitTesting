using CH3._4._6._1.LogAn.Interface;
using CH3._4._6._1.LogAn.Model;

namespace CH3._4._6._1.LogAn.Factory
{
    /// <summary>
    ///     工廠模式：
    ///         透過這邊可以產生許多不同的ExtensionManager。
    ///         但是他們都繼承於[IExtensionManager]
    ///     暴力示意：
    ///         https://www.itread01.com/content/1536127325.html
    /// </summary>
    public class ExtensionManagerFactory
    {
        private static IExtensionManager customManager = null;

        /// <summary>
        ///     調整工廠設計，使其能使用與回傳自訂的管理器物件。
        /// </summary>
        /// <returns></returns>
        public static IExtensionManager Create()
        {
            if(customManager != null)
                return customManager;
            return new FileExtensionManager();
        }

        /// <summary>
        ///     書中所指的[接縫]
        ///     提供測試程式能夠針對物件進行更多的掌控，
        ///     如狀態設定、數值內容修改...ETC
        ///     
        ///     但因為透過靜態欄位存取，因此在每個測試後都需要重置工廠的狀態。
        ///     
        /// </summary>
        /// <param name="mgr"></param>
        public static void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }

    }
}
