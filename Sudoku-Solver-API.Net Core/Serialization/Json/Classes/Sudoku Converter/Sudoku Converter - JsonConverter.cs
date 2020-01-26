using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DaanV2.Sudoku.Serialization.Json {
    ///DOLATER <summary>add description for class: SudokuConverter</summary>
    public partial class SudokuConverter : JsonConverter<Sudoku> {
        public override Sudoku Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType != JsonTokenType.StartArray) {
                throw new JsonException("Not an array");
            }

            List<Int32> Values = new List<Int32>(81);
            reader.Read();
            while (reader.TokenType == JsonTokenType.Number) {
                Values.Add(reader.GetInt32());

                reader.Read();
            }

            Sudoku Out = new Sudoku();
            Int32 I = 0;
            Out.Board.ForEach((x) => x.Value = Values[I++]);

            return Out;
        }

        public override void Write(Utf8JsonWriter writer, Sudoku value, JsonSerializerOptions options) {
            writer.WriteStartArray();
            value.Board.ForEach((x) => writer.WriteNumberValue(x.Value));
            writer.WriteEndArray();
        }
    }
}
