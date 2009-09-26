/*
 * %CopyrightBegin%
 * 
 * Copyright Takayuki Usui 2009. All Rights Reserved.
 * Copyright Ericsson AB 2000-2009. All Rights Reserved.
 * 
 * The contents of this file are subject to the Erlang Public License,
 * Version 1.1, (the "License"); you may not use this file except in
 * compliance with the License. You should have received a copy of the
 * Erlang Public License along with this software. If not, it can be
 * retrieved online at http://www.erlang.org/.
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
 * the License for the specific language governing rights and limitations
 * under the License.
 * 
 * %CopyrightEnd%
 */
using System;

namespace Erlang.NET
{
    /**
     * Provides a Java representation of Erlang booleans, which are special cases of
     * atoms with values 'true' and 'false'.
     */
    [Serializable]
    public class OtpErlangBoolean : OtpErlangAtom
    {
	// don't change this!
	internal static readonly new long serialVersionUID = 1087178844844988393L;

	/**
	 * Create a boolean from the given value
	 * 
	 * @param t
	 *                the boolean value to represent as an atom.
	 */
	public OtpErlangBoolean(bool t) : base(t)
	{
	}

	/**
	 * Create a boolean from a stream containing an atom encoded in Erlang
	 * external format. The value of the boolean will be true if the atom
	 * represented by the stream is "true" without regard to case. For other
	 * atom values, the boolean will have the value false.
	 * 
	 * @exception OtpErlangDecodeException
	 *                    if the buffer does not contain a valid external
	 *                    representation of an Erlang atom.
	 */
	public OtpErlangBoolean(OtpInputStream buf) : base(buf)
	{
	}
    }
}
