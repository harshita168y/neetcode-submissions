
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] grid = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            grid[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {

                if (board[i][j] == '.') {
                    continue;
                }

                int box = (i / 3) * 3 + (j / 3);

                if (rows[i].Contains(board[i][j]) ||
                    cols[j].Contains(board[i][j]) ||
                    grid[box].Contains(board[i][j])) {
                    return false;
                }

                rows[i].Add(board[i][j]);
                cols[j].Add(board[i][j]);
                grid[box].Add(board[i][j]);
            }
        }

        return true;
    }
}
