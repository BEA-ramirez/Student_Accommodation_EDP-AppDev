using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAccommodationPortal
{
    public static class FirestoreHelper
    {
        static string fireconfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""studentaccommodationv2"",
          ""private_key_id"": ""4852ab408a930601ad3ea51d8af8a7a4f157f7b4"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCVy7SgU2ckQ3X4\njAue6x7NwIhmW99rFKhXf/2Fan1my/5MpR9xzFhujB6MkhYoGAR6bddBnAJ8xVHP\nCMmGoim3PWIxzx7L5fZlESDIeoqfvPRjLKIQoM8oak2LHKMtGZjSLvrk4G7Pb79L\nHhUlwGLDHQqNuONMpUoEF9X/GTtZ9TMaSX6ACJH3Ov/q/j/kaELrP1l5M0v/6igM\nrf7n9fntxh+TSUOQl7rEf7tyeJopeZ0DTLd7i2WCeFjkaU4Ntm55eWRnEau5uPbw\nVtrAkI10alTCTxuUX7lOm485r0+JcRp1fweiIwznuI3DONQAuQqDBRSbnecenhoC\nvlbE398LAgMBAAECggEAEL6qvFlWaElaQKR3EBa8ZMem97pBaVjv0IgwMN/MkNcw\n4CR9NV1gbUsghxo1e9njdkQdEep8pLHyCTC0RmaOPzuPZH4AtU5JktatUXvRTzXy\nI7vzieRQA/aOIITdAMehu60gwsEL4ghd2+nK92NgJutyKJGIZyL6+SYo99E8Pzvr\n1iU94UhYiLq6vpHHy38KEM5PTXUyZEzk1LS6e+EpbOm5J7aamhvtst9e+TO8zqCD\nXVM9OQWV17nAUfR4fUzmil2ntzpaoGOW4ojnwbAV5NuiNT4XpC0a4aHVPoQSRjiv\nYgR495CtdEhn9VkysfcsL14Vqcy7g5UYhIzxUyQW8QKBgQDPXlP5cLFlZbGTCTlH\n77JX9+MT1ePI0t+BSmEGAGqzHnP8qkKbN876jGMCmvJp+IF6ro/tO8g6IrlnUUL8\n78mwrn0cSRlh/WPw7gOIF99m8vSWWQmmr3xXKBkQ1RbMbWwveOTmpEjBuB/CokGc\n6NS6Q4FXMKCR+hlXytQvjkj8zQKBgQC47Om1McmWV2pp1NJf1biWvaxcJmc1sAls\nfH91tAyGIDYJ+tsbN8dKOFq31+stGn0zh3SBsjX3Hy74/kKtBxe6ZN9GepGyirQ8\nhHbiv1db3gIclve1z4vYuYd+uu5yZV4/qqDfpRt2sVBhiVaKf8AJSveCKCmqZSTM\ngRs4DafLNwKBgAKQHeWVWPvx19IDaSvUcJXZwHq8SAZxZMXKT4ytcKQqGjDjQdN9\nSxeZqJedpqVcpu0HP0wlUwI076mxPWy24f1HCtDQrnmhkhymNHD4KpCxLAi3rQDc\nZmMFYdntaEy6hX3ItruLCEMsrWfQbZMs5YQv1WdoeHOVbb7CCQFVdt15AoGAQbnK\nkuEAMhQduUGwB+nRMpp1cUcg9b78indxYec9cEpwinmDeJgJmAKRk7gFWUGJ8E+b\nhCFP9uY5brwH/LGBqHkDtmwH7rpHtx6plovFQ9yTSZAKuK7smHnQg6Vy7GvE5MID\nbZmkOjppRFFo1c7z9RmVAMi/jlVmj9zvTKvl0F8CgYBdJnloVGT7Qerr2mPboAMv\nMSYsHu1AaPXp2SNTRcMYoDGN/EboR1Jd0SiYBfevTEMAFSbcX2nOer29vZnOa50F\noVQKUv+sNWZZRPQUYmjl6BeXqmgeHd9kzIVmYwh3Q2qWX823Nl2g8saDSAEI44js\nD7EWkx1j23qU2KKtx05g0w==\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-87gm8@studentaccommodationv2.iam.gserviceaccount.com"",
          ""client_id"": ""111247063887331755376"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-87gm8%40studentaccommodationv2.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        } ";

        static string filepath = "";
        public static FirestoreDb Database { get; private set; } 

        public static void SetEnvironmentVariables()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("studentaccommodationv2");
            File.Delete(filepath);
        }
    }
}
