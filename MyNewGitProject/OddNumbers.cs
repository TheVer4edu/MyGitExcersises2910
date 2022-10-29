using System.Collections.Generic;

namespace MyNewGitProject {
    public class OddNumbers {
        public readonly List<int> numbers;

        public OddNumbers(int max) {
            numbers = new List<int>();
            for (int i = 1; i < max; i+=2) {
                numbers.Add(i);
            }
        }

        public override string ToString() {
            return string.Join(", ", numbers);
        }
    }
}