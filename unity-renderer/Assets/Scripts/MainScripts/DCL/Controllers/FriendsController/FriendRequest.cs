namespace DCL.Social.Friends
{
    public class FriendRequest
    {
        public string FriendRequestId { get; }
        public long Timestamp { get; }
        public string From { get; }
        public string To { get; }
        public string MessageBody { get; }
        public bool HasBodyMessage => !string.IsNullOrEmpty(MessageBody);

        public FriendRequest(string friendRequestId, long timestamp, string from, string to, string messageBody)
        {
            FriendRequestId = friendRequestId;
            Timestamp = timestamp;
            From = from;
            To = to;
            MessageBody = messageBody;
        }

        public bool IsSentTo(string userId) =>
            To == userId;

        public bool IsReceivedFrom(string userId) =>
            From == userId;
    }
}
