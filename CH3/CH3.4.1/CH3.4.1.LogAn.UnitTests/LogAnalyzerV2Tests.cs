namespace CH3._4._1.LogAn.UnitTests
{
    class LogAnalyzerV2Tests
    {
        /*    
         *    由於目前程式中，
         *    LogAnalyzerV2.IsValidLogFileName中還是直接呼叫[具象類別]
         *    IExtensionManager mgr= [ new FileExtensionManagerV2() ];
         *    因此程式碼還要再進一步的去做修改，提供一個「接縫」。
         *    此部分於3.4.2中說明。
         */
    }
}
