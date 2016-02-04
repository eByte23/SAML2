using SAML2.DotNet35.Schema.Core;

namespace SAML2.DotNet35.Validation
{
    /// <summary>
    /// SAML2 Statement Validator interface.
    /// </summary>
    public interface ISaml20StatementValidator
    {
        /// <summary>
        /// Validates the statement.
        /// </summary>
        /// <param name="statement">The statement.</param>
        void ValidateStatement(StatementAbstract statement);
    }
}