using System;


namespace OPPDemo
{

    class NOKIALUMIA : MobilePhone, IWifi
    {
        #region Explicit implmentation
            //string IWifi.StartWifi()
            //{
            //    return "Starting WIFI Service";
            //}

            //string IWifi.StopWifi()
            //{
            //    return "Stoping WIFI Service";
            //}
        #endregion

        #region Implicit implementation
            public string StartWifi()
            {
            return "Starting WIFI Service";
            }

            public string StopWifi()
            {
            return "Stoping WIFI Service";   
            }

            public string TroubleShoot()
            {
                throw new NotImplementedException("This function can not be called");
            }
        #endregion
        public string PushMessage()
            {
                return "Pushing Message";
            }
    }
}
