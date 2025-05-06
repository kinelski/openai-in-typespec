/*
 * This file was automatically generated from an OpenAPI .yaml file.
 * Edits made directly to this file will be lost.
 */

using TypeSpec.OpenAPI;

namespace OpenAI;

// Tool generated type. Extracts from CodeInterpreterFileOutput.files
alias CodeInterpreterFileOutputFile = {
  /** The MIME type of the file. */
  mime_type: string;

  /** The ID of the file. */
  file_id: string;
};

/** The output of a code interpreter tool call that is a file. */
model CodeInterpreterFileOutput {
  @doc("""
    The type of the code interpreter file output. Always `files`.
    """)
  type: "files";

  files: CodeInterpreterFileOutputFile[];
}

/** The output of a code interpreter tool call that is text. */
model CodeInterpreterTextOutput {
  @doc("""
    The type of the code interpreter text output. Always `logs`.
    """)
  type: "logs";

  /** The logs of the code interpreter tool call. */
  logs: string;
}

/** A tool that runs code. */
model CodeInterpreterTool {
  @doc("""
    The type of the code interpreter tool. Always `code_interpreter`.
    """)
  type: "code_interpreter";

  /** The IDs of the files to run the code on. */
  file_ids: string[];
}

/** A tool call to run code. */
model CodeInterpreterToolCall {
  /** The unique ID of the code interpreter tool call. */
  id: string;

  @doc("""
    The type of the code interpreter tool call. Always `code_interpreter_call`.
    """)
  type: "code_interpreter_call";

  /** The code to run. */
  code: string;

  /** The status of the code interpreter tool call. */
  status: "in_progress" | "interpreting" | "completed";

  /** The results of the code interpreter tool call. */
  results: CodeInterpreterToolOutput[];
}

union CodeInterpreterToolOutput {
  CodeInterpreterTextOutput,
  CodeInterpreterFileOutput,
}

/** Emitted when there is a partial audio response. */
model ResponseAudioDeltaEvent {
  @doc("""
    The type of the event. Always `response.audio.delta`.
    """)
  type: "response.audio.delta";

  /** A chunk of Base64 encoded response audio bytes. */
  delta: string;
}

/** Emitted when the audio response is complete. */
model ResponseAudioDoneEvent {
  @doc("""
    The type of the event. Always `response.audio.done`.
    """)
  type: "response.audio.done";
}

/** Emitted when there is a partial transcript of audio. */
model ResponseAudioTranscriptDeltaEvent {
  @doc("""
    The type of the event. Always `response.audio.transcript.delta`.
    """)
  type: "response.audio.transcript.delta";

  /** The partial transcript of the audio response. */
  delta: string;
}

/** Emitted when the full audio transcript is completed. */
model ResponseAudioTranscriptDoneEvent {
  @doc("""
    The type of the event. Always `response.audio.transcript.done`.
    """)
  type: "response.audio.transcript.done";
}

/** Emitted when a partial code snippet is added by the code interpreter. */
model ResponseCodeInterpreterCallCodeDeltaEvent {
  @doc("""
    The type of the event. Always `response.code_interpreter_call.code.delta`.
    """)
  type: "response.code_interpreter_call.code.delta";

  /** The index of the output item that the code interpreter call is in progress. */
  output_index: int32;

  /** The partial code snippet added by the code interpreter. */
  delta: string;
}

/** Emitted when code snippet output is finalized by the code interpreter. */
model ResponseCodeInterpreterCallCodeDoneEvent {
  @doc("""
    The type of the event. Always `response.code_interpreter_call.code.done`.
    """)
  type: "response.code_interpreter_call.code.done";

  /** The index of the output item that the code interpreter call is in progress. */
  output_index: int32;

  /** The final code snippet output by the code interpreter. */
  code: string;
}

/** Emitted when the code interpreter call is completed. */
model ResponseCodeInterpreterCallCompletedEvent {
  @doc("""
    The type of the event. Always `response.code_interpreter_call.completed`.
    """)
  type: "response.code_interpreter_call.completed";

  /** The index of the output item that the code interpreter call is in progress. */
  output_index: int32;

  code_interpreter_call: CodeInterpreterToolCall;
}

/** Emitted when a code interpreter call is in progress. */
model ResponseCodeInterpreterCallInProgressEvent {
  @doc("""
    The type of the event. Always `response.code_interpreter_call.in_progress`.
    """)
  type: "response.code_interpreter_call.in_progress";

  /** The index of the output item that the code interpreter call is in progress. */
  output_index: int32;

  code_interpreter_call: CodeInterpreterToolCall;
}

/** Emitted when the code interpreter is actively interpreting the code snippet. */
model ResponseCodeInterpreterCallInterpretingEvent {
  @doc("""
    The type of the event. Always `response.code_interpreter_call.interpreting`.
    """)
  type: "response.code_interpreter_call.interpreting";

  /** The index of the output item that the code interpreter call is in progress. */
  output_index: int32;

  code_interpreter_call: CodeInterpreterToolCall;
}
