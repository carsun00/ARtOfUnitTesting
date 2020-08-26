using CH3.LogAn.Interface;

namespace CH3.LogAn.Factory
{
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
        ///     工廠模式：
        ///         透過這邊可以產生許多不同的ExtensionManager。
        ///         但是他們都繼承於[IExtensionManager]
        ///     暴力示意：
        ///         https://www.itread01.com/content/1536127325.html
        /// </summary>
        /// <param name="mgr"></param>
        public static void SetManager(IExtensionManager mgr)
        {
            customManager = mgr;
        }

    }
}
