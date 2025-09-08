namespace Tasks.Poc.Contracts.Constants.Aspire;

public static class ParameterDescriptions
{
    public static class Keycloak
    {
        public const string Realm = """
            🔐 The Keycloak realm to use for authentication.
            This should match the realm configured in your Keycloak server.

            ⚠️  Important: The realm name is case-sensitive and must exist in your Keycloak instance.
            💡 Default value: 'master' (not recommended for production)
            📋 Example: 'bookworm-realm' or 'production'

            📚 Resources:
            - For more information, visit: https://www.keycloak.org/docs/latest/server_admin/#_realms
            - To create a new realm, go to: https://www.keycloak.org/docs/latest/server_admin/#_creating_a_realm
            """;

        public const string Theme = """
            🎨 Keycloak theme name to use for the BookWorm application.
            This customizes the appearance of login and registration pages.

            💡 Default: 'keycloak' (built-in theme)
            📋 Example: 'bookworm-theme' or 'custom-theme'

            📚 To create custom themes, visit: https://www.keycloak.org/docs/latest/server_development/#_themes
            """;

        public const string ThemeDisplayName = """
            🏷️  Keycloak theme display name to use for the BookWorm application.
            This is the human-readable name shown in the Keycloak admin console.

            💡 Default: Same as theme name
            📋 Example: 'BookWorm Custom Theme' or 'Production Theme'
            """;
    }

    public static class Postgres
    {
        public const string User = """
            👤 The PostgreSQL user to use for the BookWorm application.
            This user should have the necessary permissions to access the BookWorm database.

            🔒 Required permissions: CREATE, SELECT, INSERT, UPDATE, DELETE on BookWorm schemas
            ⚠️  Security note: Use a dedicated application user, not the postgres superuser
            💡 Default: 'postgres' (not recommended for production)
            📋 Example: 'bookworm_user' or 'app_user'

            📚 Resources:
            - For more information, visit: https://www.postgresql.org/docs/current/user-manag.html
            - To create a new user, go to: https://www.postgresql.org/docs/current/sql-createuser.html
            - Best practices: https://www.postgresql.org/docs/current/sql-grant.html
            """;

        public const string Password = """
            🔑 The password for the PostgreSQL user.
            Ensure this password meets your security requirements.

            🔒 Security requirements:
            - Minimum 12 characters recommended
            - Mix of uppercase, lowercase, numbers, and special characters
            - Avoid common passwords and dictionary words

            ⚠️  Important: Store securely and rotate regularly in production
            🛡️  Consider using Azure Key Vault or similar secret management

            📚 Resources:
            - For more information, visit: https://www.postgresql.org/docs/current/auth-passwords.html
            - To change a user's password, go to: https://www.postgresql.org/docs/current/sql-alteruser.html
            - Password security: https://www.postgresql.org/docs/current/auth-password.html
            """;
    }

    public static class SendGrid
    {
        public const string ApiKey = """
            🔐 SendGrid API key for authentication.
            You can obtain it from your SendGrid account dashboard.

            🔒 Security requirements:
            - Use 'Mail Send' permission only (principle of least privilege)
            - Store securely in production (Azure Key Vault recommended)
            - Rotate keys regularly for enhanced security

            ⚠️  Important: Never commit API keys to source control
            💡 Format: Starts with 'SG.' followed by base64-encoded string
            📋 Example: 'SG.abc123def456...' (69 characters total)

            📚 Resources:
            - For more information, visit: https://app.sendgrid.com/settings/api_keys
            - To create a new API key, go to: https://app.sendgrid.com/settings/api_keys/create
            - API key permissions: https://docs.sendgrid.com/ui/account-and-settings/api-keys#api-key-permissions
            """;

        public const string SenderEmail = """
            📧 Sender email address for outgoing emails.
            This should be a verified email address in your SendGrid account.

            ✅ Requirements:
            - Must be verified in SendGrid sender authentication
            - Should match your domain for better deliverability
            - Avoid using no-reply addresses when possible

            💡 Best practices:
            - Use a monitored email address (e.g., notifications@bookworm.com)
            - Consider using subdomain for transactional emails
            📋 Example: 'noreply@bookworm.com' or 'notifications@yourdomain.com'

            📚 Resources:
            - For more information, visit: https://app.sendgrid.com/settings/sender_auth
            - To verify a new sender email, go to: https://app.sendgrid.com/settings/sender_auth/single_sender
            - Sender authentication guide: https://docs.sendgrid.com/ui/sending-email/sender-verification
            """;

        public const string SenderName = """
            👤 Sender name for outgoing emails.
            This is the name that will appear in the 'From' field of the email.

            💡 Best practices:
            - Use a recognizable brand or application name
            - Keep it concise and professional
            - Avoid special characters or excessive length

            📋 Examples: 'BookWorm App', 'BookWorm Notifications', or 'Your Company Name'
            ⚠️  Note: Some email clients may override this with the email address

            📚 Resources:
            - For more information, visit: https://app.sendgrid.com/settings/sender_auth
            - Email deliverability best practices: https://docs.sendgrid.com/ui/sending-email/deliverability
            """;
    }

    public static class Scheduler
    {
        public const string UserName = """
            👤 The username for the BookWorm scheduler application.
            This user will be used to authenticate with the scheduler service.

            💡 Default: 'admin' (not recommended for production)
            📋 Example: 'scheduler_user' or 'bookworm_scheduler'

            ⚠️  Important: Use a unique username for the scheduler service
            """;

        public const string Password = """
            🔑 The password for the BookWorm scheduler application.
            Ensure this password meets your security requirements.

            🔒 Security requirements:
            - Minimum 16 characters recommended
            - Mix of uppercase, lowercase, numbers, and special characters
            - Avoid common passwords and dictionary words

            ⚠️  Important: Store securely and rotate regularly in production
            🛡️  Consider using Azure Key Vault or similar secret management
            """;
    }

    public static class Cors
    {
        public const string BackOfficeUrl = """
            🌐 The URL of the BackOffice application for CORS configuration.
            This allows the BookWorm API to accept requests from the BackOffice domain.

            💡 Example: 'https://admin.bookworm.com'
            ⚠️  Important: Must match the actual BackOffice URL in production
            📋 Format: Must be a valid URL (including protocol)

            📚 Resources:
            - For more information, visit: https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS
            - CORS configuration guide: https://docs.microsoft.com/en-us/aspnet/core/security/cors
            """;

        public const string StoreFrontUrl = """
            🌐 The URL of the StoreFront application for CORS configuration.
            This allows the BookWorm API to accept requests from the StoreFront domain.

            💡 Example: 'https://bookworm.com'
            ⚠️  Important: Must match the actual StoreFront URL in production
            📋 Format: Must be a valid URL (including protocol)

            📚 Resources:
            - For more information, visit: https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS
            - CORS configuration guide: https://docs.microsoft.com/en-us/aspnet/core/security/cors
            """;
    }
}
