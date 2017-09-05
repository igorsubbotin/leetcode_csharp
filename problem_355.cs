// 355. Design Twitter - https://leetcode.com/problems/design-twitter
public class Twitter {
    private int time = -1;
    private readonly HashSet<int> users = new HashSet<int>();
    private readonly IDictionary<int, HashSet<int>> subscriptions = new Dictionary<int, HashSet<int>>();
    private readonly IDictionary<int, IList<int[]>> tweets = new Dictionary<int, IList<int[]>>();
    
    
    /** Initialize your data structure here. */
    public Twitter() {
        
    }
    
    /** Compose a new tweet. */
    public void PostTweet(int userId, int tweetId) {
        CheckUser(userId);
        tweets[userId].Add(new [] { time++, tweetId });
    }
    
    /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
    public IList<int> GetNewsFeed(int userId) {
        CheckUser(userId);
        var feed = new List<int[]>();
        foreach (var followeeId in subscriptions[userId])
            foreach (var tweet in tweets[followeeId])
                feed.Add(tweet);
        return feed.OrderByDescending(x => x[0]).Take(10).Select(x => x[1]).ToList();
    }
    
    /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
    public void Follow(int followerId, int followeeId) {
        CheckUsers(new [] { followerId, followeeId });
        var userSubscriptions = subscriptions[followerId];
        if (userSubscriptions.Contains(followeeId)) return;
        userSubscriptions.Add(followeeId);
    }
    
    /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
    public void Unfollow(int followerId, int followeeId) {
        CheckUsers(new [] { followerId, followeeId });
        if (followerId == followeeId) return;
        var userSubscriptions = subscriptions[followerId];
        if (!userSubscriptions.Contains(followeeId)) return;
        userSubscriptions.Remove(followeeId);
    }
    
    private void CheckUsers(int[] userIds) {
        foreach (var userId in userIds) CheckUser(userId);
    }
    private void CheckUser(int userId) {
        CreateUserIfNeeded(userId);
    }
    private void CreateUserIfNeeded(int userId) {
        if (users.Contains(userId)) return;
        users.Add(userId);
        subscriptions[userId] = new HashSet<int> { userId };
        tweets[userId] = new List<int[]>();
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */