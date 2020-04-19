/*
 * @lc app=leetcode.cn id=3 lang=javascript
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
  let l = 0;
  let set = new Set();
  if (s.length > 1) {
    for (let i = 0; i < s.length; i++) {
      set.clear();
      set = set.add(s[i]);
      for (let j = i + 1; j < s.length; j++) {
        if (set.has(s[j])) {
          l = Math.max(j - i, l);
          break;
        }
        set.add(s[j]);
        if (j === s.length - 1) {
          l = Math.max(j - i + 1, l);
        }
      }
    }
  } else if (s.length === 1) {
    l = 1;
  }
  return l;
};
// @lc code=end

lengthOfLongestSubstring("au");
