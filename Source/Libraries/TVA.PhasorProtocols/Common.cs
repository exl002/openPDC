//*******************************************************************************************************
//  Common.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  02/18/2005 - J. Ritchie Carroll
//       Generated original version of source code.
//  09/15/2009 - Stephen C. Wills
//       Added new header and license agreement.
//  04/21/2010 - J.Ritchie Carroll
//       Added GetFormattedSignalTypeName signal type enumeration extension.
//
//*******************************************************************************************************

#region [ TVA Open Source Agreement ]
/*

 THIS OPEN SOURCE AGREEMENT ("AGREEMENT") DEFINES THE RIGHTS OF USE,REPRODUCTION, DISTRIBUTION,
 MODIFICATION AND REDISTRIBUTION OF CERTAIN COMPUTER SOFTWARE ORIGINALLY RELEASED BY THE
 TENNESSEE VALLEY AUTHORITY, A CORPORATE AGENCY AND INSTRUMENTALITY OF THE UNITED STATES GOVERNMENT
 ("GOVERNMENT AGENCY"). GOVERNMENT AGENCY IS AN INTENDED THIRD-PARTY BENEFICIARY OF ALL SUBSEQUENT
 DISTRIBUTIONS OR REDISTRIBUTIONS OF THE SUBJECT SOFTWARE. ANYONE WHO USES, REPRODUCES, DISTRIBUTES,
 MODIFIES OR REDISTRIBUTES THE SUBJECT SOFTWARE, AS DEFINED HEREIN, OR ANY PART THEREOF, IS, BY THAT
 ACTION, ACCEPTING IN FULL THE RESPONSIBILITIES AND OBLIGATIONS CONTAINED IN THIS AGREEMENT.

 Original Software Designation: openPDC
 Original Software Title: The TVA Open Source Phasor Data Concentrator
 User Registration Requested. Please Visit https://naspi.tva.com/Registration/
 Point of Contact for Original Software: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>

 1. DEFINITIONS

 A. "Contributor" means Government Agency, as the developer of the Original Software, and any entity
 that makes a Modification.

 B. "Covered Patents" mean patent claims licensable by a Contributor that are necessarily infringed by
 the use or sale of its Modification alone or when combined with the Subject Software.

 C. "Display" means the showing of a copy of the Subject Software, either directly or by means of an
 image, or any other device.

 D. "Distribution" means conveyance or transfer of the Subject Software, regardless of means, to
 another.

 E. "Larger Work" means computer software that combines Subject Software, or portions thereof, with
 software separate from the Subject Software that is not governed by the terms of this Agreement.

 F. "Modification" means any alteration of, including addition to or deletion from, the substance or
 structure of either the Original Software or Subject Software, and includes derivative works, as that
 term is defined in the Copyright Statute, 17 USC § 101. However, the act of including Subject Software
 as part of a Larger Work does not in and of itself constitute a Modification.

 G. "Original Software" means the computer software first released under this Agreement by Government
 Agency entitled openPDC, including source code, object code and accompanying documentation, if any.

 H. "Recipient" means anyone who acquires the Subject Software under this Agreement, including all
 Contributors.

 I. "Redistribution" means Distribution of the Subject Software after a Modification has been made.

 J. "Reproduction" means the making of a counterpart, image or copy of the Subject Software.

 K. "Sale" means the exchange of the Subject Software for money or equivalent value.

 L. "Subject Software" means the Original Software, Modifications, or any respective parts thereof.

 M. "Use" means the application or employment of the Subject Software for any purpose.

 2. GRANT OF RIGHTS

 A. Under Non-Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor,
 with respect to its own contribution to the Subject Software, hereby grants to each Recipient a
 non-exclusive, world-wide, royalty-free license to engage in the following activities pertaining to
 the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Modification

 5. Redistribution

 6. Display

 B. Under Patent Rights: Subject to the terms and conditions of this Agreement, each Contributor, with
 respect to its own contribution to the Subject Software, hereby grants to each Recipient under Covered
 Patents a non-exclusive, world-wide, royalty-free license to engage in the following activities
 pertaining to the Subject Software:

 1. Use

 2. Distribution

 3. Reproduction

 4. Sale

 5. Offer for Sale

 C. The rights granted under Paragraph B. also apply to the combination of a Contributor's Modification
 and the Subject Software if, at the time the Modification is added by the Contributor, the addition of
 such Modification causes the combination to be covered by the Covered Patents. It does not apply to
 any other combinations that include a Modification. 

 D. The rights granted in Paragraphs A. and B. allow the Recipient to sublicense those same rights.
 Such sublicense must be under the same terms and conditions of this Agreement.

 3. OBLIGATIONS OF RECIPIENT

 A. Distribution or Redistribution of the Subject Software must be made under this Agreement except for
 additions covered under paragraph 3H. 

 1. Whenever a Recipient distributes or redistributes the Subject Software, a copy of this Agreement
 must be included with each copy of the Subject Software; and

 2. If Recipient distributes or redistributes the Subject Software in any form other than source code,
 Recipient must also make the source code freely available, and must provide with each copy of the
 Subject Software information on how to obtain the source code in a reasonable manner on or through a
 medium customarily used for software exchange.

 B. Each Recipient must ensure that the following copyright notice appears prominently in the Subject
 Software:

          No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.

 C. Each Contributor must characterize its alteration of the Subject Software as a Modification and
 must identify itself as the originator of its Modification in a manner that reasonably allows
 subsequent Recipients to identify the originator of the Modification. In fulfillment of these
 requirements, Contributor must include a file (e.g., a change log file) that describes the alterations
 made and the date of the alterations, identifies Contributor as originator of the alterations, and
 consents to characterization of the alterations as a Modification, for example, by including a
 statement that the Modification is derived, directly or indirectly, from Original Software provided by
 Government Agency. Once consent is granted, it may not thereafter be revoked.

 D. A Contributor may add its own copyright notice to the Subject Software. Once a copyright notice has
 been added to the Subject Software, a Recipient may not remove it without the express permission of
 the Contributor who added the notice.

 E. A Recipient may not make any representation in the Subject Software or in any promotional,
 advertising or other material that may be construed as an endorsement by Government Agency or by any
 prior Recipient of any product or service provided by Recipient, or that may seek to obtain commercial
 advantage by the fact of Government Agency's or a prior Recipient's participation in this Agreement.

 F. In an effort to track usage and maintain accurate records of the Subject Software, each Recipient,
 upon receipt of the Subject Software, is requested to register with Government Agency by visiting the
 following website: https://naspi.tva.com/Registration/. Recipient's name and personal information
 shall be used for statistical purposes only. Once a Recipient makes a Modification available, it is
 requested that the Recipient inform Government Agency at the web site provided above how to access the
 Modification.

 G. Each Contributor represents that that its Modification does not violate any existing agreements,
 regulations, statutes or rules, and further that Contributor has sufficient rights to grant the rights
 conveyed by this Agreement.

 H. A Recipient may choose to offer, and to charge a fee for, warranty, support, indemnity and/or
 liability obligations to one or more other Recipients of the Subject Software. A Recipient may do so,
 however, only on its own behalf and not on behalf of Government Agency or any other Recipient. Such a
 Recipient must make it absolutely clear that any such warranty, support, indemnity and/or liability
 obligation is offered by that Recipient alone. Further, such Recipient agrees to indemnify Government
 Agency and every other Recipient for any liability incurred by them as a result of warranty, support,
 indemnity and/or liability offered by such Recipient.

 I. A Recipient may create a Larger Work by combining Subject Software with separate software not
 governed by the terms of this agreement and distribute the Larger Work as a single product. In such
 case, the Recipient must make sure Subject Software, or portions thereof, included in the Larger Work
 is subject to this Agreement.

 J. Notwithstanding any provisions contained herein, Recipient is hereby put on notice that export of
 any goods or technical data from the United States may require some form of export license from the
 U.S. Government. Failure to obtain necessary export licenses may result in criminal liability under
 U.S. laws. Government Agency neither represents that a license shall not be required nor that, if
 required, it shall be issued. Nothing granted herein provides any such export license.

 4. DISCLAIMER OF WARRANTIES AND LIABILITIES; WAIVER AND INDEMNIFICATION

 A. No Warranty: THE SUBJECT SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTY OF ANY KIND, EITHER
 EXPRESSED, IMPLIED, OR STATUTORY, INCLUDING, BUT NOT LIMITED TO, ANY WARRANTY THAT THE SUBJECT
 SOFTWARE WILL CONFORM TO SPECIFICATIONS, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
 PARTICULAR PURPOSE, OR FREEDOM FROM INFRINGEMENT, ANY WARRANTY THAT THE SUBJECT SOFTWARE WILL BE ERROR
 FREE, OR ANY WARRANTY THAT DOCUMENTATION, IF PROVIDED, WILL CONFORM TO THE SUBJECT SOFTWARE. THIS
 AGREEMENT DOES NOT, IN ANY MANNER, CONSTITUTE AN ENDORSEMENT BY GOVERNMENT AGENCY OR ANY PRIOR
 RECIPIENT OF ANY RESULTS, RESULTING DESIGNS, HARDWARE, SOFTWARE PRODUCTS OR ANY OTHER APPLICATIONS
 RESULTING FROM USE OF THE SUBJECT SOFTWARE. FURTHER, GOVERNMENT AGENCY DISCLAIMS ALL WARRANTIES AND
 LIABILITIES REGARDING THIRD-PARTY SOFTWARE, IF PRESENT IN THE ORIGINAL SOFTWARE, AND DISTRIBUTES IT
 "AS IS."

 B. Waiver and Indemnity: RECIPIENT AGREES TO WAIVE ANY AND ALL CLAIMS AGAINST GOVERNMENT AGENCY, ITS
 AGENTS, EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT. IF RECIPIENT'S USE
 OF THE SUBJECT SOFTWARE RESULTS IN ANY LIABILITIES, DEMANDS, DAMAGES, EXPENSES OR LOSSES ARISING FROM
 SUCH USE, INCLUDING ANY DAMAGES FROM PRODUCTS BASED ON, OR RESULTING FROM, RECIPIENT'S USE OF THE
 SUBJECT SOFTWARE, RECIPIENT SHALL INDEMNIFY AND HOLD HARMLESS  GOVERNMENT AGENCY, ITS AGENTS,
 EMPLOYEES, CONTRACTORS AND SUBCONTRACTORS, AS WELL AS ANY PRIOR RECIPIENT, TO THE EXTENT PERMITTED BY
 LAW.  THE FOREGOING RELEASE AND INDEMNIFICATION SHALL APPLY EVEN IF THE LIABILITIES, DEMANDS, DAMAGES,
 EXPENSES OR LOSSES ARE CAUSED, OCCASIONED, OR CONTRIBUTED TO BY THE NEGLIGENCE, SOLE OR CONCURRENT, OF
 GOVERNMENT AGENCY OR ANY PRIOR RECIPIENT.  RECIPIENT'S SOLE REMEDY FOR ANY SUCH MATTER SHALL BE THE
 IMMEDIATE, UNILATERAL TERMINATION OF THIS AGREEMENT.

 5. GENERAL TERMS

 A. Termination: This Agreement and the rights granted hereunder will terminate automatically if a
 Recipient fails to comply with these terms and conditions, and fails to cure such noncompliance within
 thirty (30) days of becoming aware of such noncompliance. Upon termination, a Recipient agrees to
 immediately cease use and distribution of the Subject Software. All sublicenses to the Subject
 Software properly granted by the breaching Recipient shall survive any such termination of this
 Agreement.

 B. Severability: If any provision of this Agreement is invalid or unenforceable under applicable law,
 it shall not affect the validity or enforceability of the remainder of the terms of this Agreement.

 C. Applicable Law: This Agreement shall be subject to United States federal law only for all purposes,
 including, but not limited to, determining the validity of this Agreement, the meaning of its
 provisions and the rights, obligations and remedies of the parties.

 D. Entire Understanding: This Agreement constitutes the entire understanding and agreement of the
 parties relating to release of the Subject Software and may not be superseded, modified or amended
 except by further written agreement duly executed by the parties.

 E. Binding Authority: By accepting and using the Subject Software under this Agreement, a Recipient
 affirms its authority to bind the Recipient to all terms and conditions of this Agreement and that
 Recipient hereby agrees to all terms and conditions herein.

 F. Point of Contact: Any Recipient contact with Government Agency is to be directed to the designated
 representative as follows: J. Ritchie Carroll <mailto:jrcarrol@tva.gov>.

*/
#endregion

using System;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Soap;
using TimeSeriesFramework;
using TVA.Parsing;

namespace TVA.PhasorProtocols
{
    /// <summary>
    /// Common constants, functions and extensions for phasor classes.
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// Typical data stream synchrnonization byte.
        /// </summary>
        public const byte SyncByte = 0xAA;

        /// <summary>
        /// Undefined measurement key.
        /// </summary>
        internal static MeasurementKey UndefinedKey = new MeasurementKey(Guid.Empty, uint.MaxValue, "__");

        /// <summary>
        /// This is a common optimized block copy function for binary data.
        /// </summary>
        /// <param name="source">Source buffer to copy data from.</param>
        /// <param name="destination">Destination buffer to hold copied buffer data.</param>
        /// <param name="index">Index into <paramref name="destination"/> buffer to begin copy.  Index is automatically incremented by <paramref name="length"/>.</param>
        /// <param name="length">Number of bytes to copy from source.</param>
        /// <remarks>
        /// Source index is always zero so hence not requested. This function automatically advances index for convenience.
        /// </remarks>
        public static void CopyImage(this byte[] source, byte[] destination, ref int index, int length)
        {
            if (length > 0)
            {
                Buffer.BlockCopy(source, 0, destination, index, length);
                index += length;
            }
        }

        /// <summary>
        /// This is a common optimized block copy function for any kind of data.
        /// </summary>
        /// <param name="channel">Source channel with BinaryImage data to copy.</param>
        /// <param name="destination">Destination buffer to hold copied buffer data.</param>
        /// <param name="index">
        /// Index into <paramref name="destination"/> buffer to begin copy. Index is automatically incremented by <see cref="ISupportBinaryImage.BinaryLength"/>.
        /// </param>
        /// <remarks>
        /// This function automatically advances index for convenience.
        /// </remarks>
        public static void CopyImage(this ISupportBinaryImage channel, byte[] destination, ref int index)
        {
            index += channel.GenerateBinaryImage(destination, index);
        }

        /// <summary>
        /// Deserializes a configuration frame from an XML file.
        /// </summary>
        /// <param name="configFileName">Path and file name of XML configuration file.</param>
        /// <returns>Deserialized <see cref="IConfigurationFrame"/>.</returns>
        public static IConfigurationFrame DeserializeConfigurationFrame(string configFileName)
        {
            IConfigurationFrame configFrame = null;
            FileStream configFile = null;

            try
            {
                configFile = File.Open(configFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                configFrame = DeserializeConfigurationFrame(configFile);
            }
            finally
            {
                if (configFile != null)
                    configFile.Close();
            }

            return configFrame;
        }

        /// <summary>
        /// Deserializes a configuration frame from an XML stream.
        /// </summary>
        /// <param name="configStream"><see cref="Stream"/> that contains an XML serialized configuration frame.</param>
        /// <returns>Deserialized <see cref="IConfigurationFrame"/>.</returns>
        public static IConfigurationFrame DeserializeConfigurationFrame(Stream configStream)
        {
            IConfigurationFrame configFrame = null;
            SoapFormatter xmlSerializer = new SoapFormatter();

            // TODO: When project is renamed to "PhasorProtocols.dll", uncomment the following:
            //string xmlFile = Encoding.Default.GetString(configStream.ReadStream());            
            //xmlFile = xmlFile.Replace("TVA.Phasors", "PhasorProtocols");
            //xmlFile = xmlFile.Replace("TVA.PhasorProtocols", "PhasorProtocols");

            xmlSerializer.AssemblyFormat = FormatterAssemblyStyle.Simple;
            xmlSerializer.TypeFormat = FormatterTypeStyle.TypesWhenNeeded;

            //configFrame = xmlSerializer.Deserialize(new MemoryStream(Encoding.Default.GetBytes(xmlFile))) as IConfigurationFrame;
            configFrame = xmlSerializer.Deserialize(configStream) as IConfigurationFrame;

            return configFrame;
        }

        /// <summary>
        /// Removes duplicate white space, control characters and null from a string.
        /// </summary>
        /// <param name="value">Source <see cref="String"/> to validate.</param>
        /// <remarks>
        /// Strings reported from field devices can be full of inconsistencies, this function "cleans-up" the strings for visualization.
        /// </remarks>
        /// <returns><paramref name="value"/> with duplicate white space, control characters and nulls removed.</returns>
        public static string GetValidLabel(this string value)
        {
            return value.RemoveNull().ReplaceControlCharacters().RemoveDuplicateWhiteSpace().Trim();
        }

        /// <summary>
        /// Returns display friendly protocol name.
        /// </summary>
        /// <param name="protocol"><see cref="PhasorProtocol"/> to return display name for.</param>
        /// <returns>Friendly protocol display name for specified phasor <paramref name="protocol"/>.</returns>
        public static string GetFormattedProtocolName(this PhasorProtocol protocol)
        {
            switch (protocol)
            {
                case PhasorProtocol.IeeeC37_118V2:
                    return "IEEE C37.118-2011, R2"; // TODO: Update later
                case PhasorProtocol.IeeeC37_118V1:
                    return "IEEE C37.118-2005";
                case PhasorProtocol.IeeeC37_118D6:
                    return "IEEE C37.118 Draft 6";
                case PhasorProtocol.Ieee1344:
                    return "IEEE 1344-1995";
                case PhasorProtocol.BpaPdcStream:
                    return "BPA PDCstream";
                case PhasorProtocol.FNet:
                    return "Virginia Tech F-NET";
                case PhasorProtocol.SelFastMessage:
                    return "SEL Fast Message";
                case PhasorProtocol.Macrodyne:
                    return "Macrodyne";
                default:
                    return protocol.ToString().Replace('_', '.').ToUpper();
            }
        }

        /// <summary>
        /// Returns display friendly signal type name.
        /// </summary>
        /// <param name="signalType"><see cref="SignalType"/> to return display name for.</param>
        /// <returns>Friendly protocol display name for specified <paramref name="signalType"/>.</returns>
        public static string GetFormattedSignalTypeName(this SignalType signalType)
        {
            switch (signalType)
            {
                case SignalType.IPHM:
                    return "Current phase magnitude";
                case SignalType.IPHA:
                    return "Current phase angle";
                case SignalType.VPHM:
                    return "Voltage phase magnitude";
                case SignalType.VPHA:
                    return "Voltage phase angle";
                case SignalType.FREQ:
                    return "Frequency";
                case SignalType.DFDT:
                    return "Frequency delta (dF/dt)";
                case SignalType.ALOG:
                    return "Analog";
                case SignalType.FLAG:
                    return "Status flags";
                case SignalType.DIGI:
                    return "Digital";
                case SignalType.CALC:
                    return "Calculated";
                case SignalType.NONE:
                    return "Undefined";
                default:
                    return signalType.ToString().ToTitleCase();
            }
        }
    }
}