﻿namespace Sharp.Xmpp.Extensions.XEP_0045
{
    /// <summary>
    /// Describes whether a conference room requires a membership to enter.
    /// </summary>
    public enum RoomPrivacy
    {
        /// <summary>
        /// A room that non-banned entities are allowed to enter
        /// without being on the member list.
        /// </summary>
        Open,

        /// <summary>
        /// A room that a user cannot enter without being on the member list.
        /// </summary>
        MembersOnly
    }
}