using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Limbo.ApiAuthentication.Tokens.Generators {
    /// <summary>
    /// A token generator
    /// </summary>
    public interface ITokenGenerator {
        /// <summary>
        /// Generates a token
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="expiresOn"></param>
        /// <param name="issuer"></param>
        /// <param name="audience"></param>
        /// <param name="claims"></param>
        /// <param name="algorithm"></param>
        /// <returns></returns>
        string Generate(string secretKey, DateTime expiresOn, string issuer, string audience, List<Claim> claims, string algorithm = "HS256");
    }
}
