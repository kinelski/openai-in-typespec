// Import order matters. Somehow, importing the server decorated namespace afterwards,
// will cause the the `description` field to be missing in the generated OpenAPI spec.
import "./client.tsp";
import "./specialized-types.tsp";
import "./extra-types.tsp";
import "../../typespec/servers/rest.tsp";
import "../../typespec";

import "@azure-tools/typespec-client-generator-core";

using Azure.ClientGenerator.Core;
using OpenAI;

@@access(FineTuningJobsPageToken, Access.public);
@@usage(FineTuningJobsPageToken, Usage.input);

@@access(CreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum,
  Usage.input
);
@@access(CreateFineTuningJobRequestHyperparametersNEpochsOption, Access.public);
@@usage(CreateFineTuningJobRequestHyperparametersNEpochsOption, Usage.input);

@@access(CreateFineTuningJobRequestHyperparametersLearningRateMultiplierChoiceEnum,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersLearningRateMultiplierChoiceEnum,
  Usage.input
);
@@access(CreateFineTuningJobRequestHyperparametersLearningRateMultiplierOption,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersLearningRateMultiplierOption,
  Usage.input
);

@@access(CreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersBatchSizeChoiceEnum,
  Usage.input
);
@@access(CreateFineTuningJobRequestHyperparametersBatchSizeOption,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersBatchSizeOption, Usage.input);

@@access(CreateFineTuningJobRequestHyperparametersBetaChoiceEnum,
  Access.public
);
@@usage(CreateFineTuningJobRequestHyperparametersBetaChoiceEnum, Usage.input);
@@access(CreateFineTuningJobRequestHyperparametersBetaOption, Access.public);
@@usage(CreateFineTuningJobRequestHyperparametersBetaOption, Usage.input);