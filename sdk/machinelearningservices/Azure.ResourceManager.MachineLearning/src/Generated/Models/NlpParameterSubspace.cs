// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Stringified search spaces for each parameter. See below examples. </summary>
    public partial class NlpParameterSubspace
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NlpParameterSubspace"/>. </summary>
        public NlpParameterSubspace()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NlpParameterSubspace"/>. </summary>
        /// <param name="gradientAccumulationSteps"> Number of steps to accumulate gradients over before running a backward pass. </param>
        /// <param name="learningRate"> The learning rate for the training procedure. </param>
        /// <param name="learningRateScheduler"> The type of learning rate schedule to use during the training procedure. </param>
        /// <param name="modelName"> The name of the model to train. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. </param>
        /// <param name="trainingBatchSize"> The batch size for the training procedure. </param>
        /// <param name="validationBatchSize"> The batch size to be used during evaluation. </param>
        /// <param name="warmupRatio"> The warmup ratio, used alongside LrSchedulerType. </param>
        /// <param name="weightDecay"> The weight decay for the training procedure. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NlpParameterSubspace(string gradientAccumulationSteps, string learningRate, string learningRateScheduler, string modelName, string numberOfEpochs, string trainingBatchSize, string validationBatchSize, string warmupRatio, string weightDecay, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GradientAccumulationSteps = gradientAccumulationSteps;
            LearningRate = learningRate;
            LearningRateScheduler = learningRateScheduler;
            ModelName = modelName;
            NumberOfEpochs = numberOfEpochs;
            TrainingBatchSize = trainingBatchSize;
            ValidationBatchSize = validationBatchSize;
            WarmupRatio = warmupRatio;
            WeightDecay = weightDecay;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Number of steps to accumulate gradients over before running a backward pass. </summary>
        public string GradientAccumulationSteps { get; set; }
        /// <summary> The learning rate for the training procedure. </summary>
        public string LearningRate { get; set; }
        /// <summary> The type of learning rate schedule to use during the training procedure. </summary>
        public string LearningRateScheduler { get; set; }
        /// <summary> The name of the model to train. </summary>
        public string ModelName { get; set; }
        /// <summary> Number of training epochs. </summary>
        public string NumberOfEpochs { get; set; }
        /// <summary> The batch size for the training procedure. </summary>
        public string TrainingBatchSize { get; set; }
        /// <summary> The batch size to be used during evaluation. </summary>
        public string ValidationBatchSize { get; set; }
        /// <summary> The warmup ratio, used alongside LrSchedulerType. </summary>
        public string WarmupRatio { get; set; }
        /// <summary> The weight decay for the training procedure. </summary>
        public string WeightDecay { get; set; }
    }
}
