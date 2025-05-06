import "@typespec/versioning";
import "../../typespec/chat/models.tsp";

using TypeSpec.Versioning;

namespace AzureOpenAI;

union AzureChatDataSourceAuthenticationOptionsType {
  api_key: "api_key",

  @added(AzureOpenAIServiceApiVersion.v2024_08_01_preview)
  username_and_password: "username_and_password",

  connection_string: "connection_string",
  key_and_key_id: "key_and_key_id",
  encoded_api_key: "encoded_api_key",
  access_token: "access_token",
  system_assigned_managed_identity: "system_assigned_managed_identity",
  user_assigned_managed_identity: "user_assigned_managed_identity",
}

@discriminator("type")
model AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType;
}

model AzureChatDataSourceApiKeyAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.api_key;
  key: string;
}

@added(AzureOpenAIServiceApiVersion.v2024_08_01_preview)
model AzureChatDataSourceUsernameAndPasswordAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.username_and_password;
  username: string;
  password: string;
}

model AzureChatDataSourceConnectionStringAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.connection_string;
  connection_string: string;
}

model AzureChatDataSourceKeyAndKeyIdAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.key_and_key_id;
  key: string;
  key_id: string;
}

model AzureChatDataSourceEncodedApiKeyAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.encoded_api_key;
  encoded_api_key: string;
}

model AzureChatDataSourceAccessTokenAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.access_token;
  access_token: string;
}

model AzureChatDataSourceSystemAssignedManagedIdentityAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.system_assigned_managed_identity;
}

model AzureChatDataSourceUserAssignedManagedIdentityAuthenticationOptions
  extends AzureChatDataSourceAuthenticationOptions {
  type: AzureChatDataSourceAuthenticationOptionsType.user_assigned_managed_identity;
  managed_identity_resource_id: string;
}
