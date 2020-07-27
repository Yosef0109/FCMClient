using System;
using Android.App;
using Firebase.Iid;
using Android.Util;

namespace FCMClient.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.INSTANCE_ID_EVENT"})]
    public class MyFirebaseIIDService : FirebaseInstanceIdService
    {
        const string TAG = "MyFirebaseIIDService";
        public override void OnTokenRefresh()
        {
            var refreshToken = FirebaseInstanceId.Instance.Token;
            Log.Debug(TAG, "Refreshed token: " + refreshToken);
            SendRegistrationToServer(refreshToken);
        }

        void SendRegistrationToServer(string token)
        {

        }
    }
}