namespace UrlParametersTask
{
    using System;

    /// <summary>
    /// A class that contains methods to work with URLs.
    /// </summary>
    public class UrlParametersMethods
    {
        /// <summary>
        /// A method that adds url parameter or changes it's value if it's already exists.
        /// </summary>
        /// <param name="url">An URL.</param>
        /// <param name="parameter">A parameter to add or change.</param>
        /// <returns>URL.</returns>
        public static string AddOrChangeUrlParameter(string url, string parameter)
        {
            if (url == null || parameter == null)
            {
                throw new ArgumentNullException();
            }

            string[] temporary = url.Split('?');

            if (temporary.Length == 2)
            {
                string[] tempParameters = temporary[1].Split('&');
                for (int i = 0; i < tempParameters.Length; i++)
                {
                    if (tempParameters[i].Split('=')[0] == parameter.Split('=')[0])
                    {
                        tempParameters[i] = tempParameters[i].Split('=')[0] + "=" + parameter.Split('=')[1];
                        temporary[1] = string.Join("&", tempParameters);
                        return string.Join("?", temporary);
                    }
                }

                return url + "&" + parameter;
            }

            return url + "?" + parameter;
        }
    }
}
