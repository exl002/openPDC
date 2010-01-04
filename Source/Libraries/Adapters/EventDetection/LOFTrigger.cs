﻿//*******************************************************************************************************
//  LOFTrigger.cs - Gbtc
//
//  Tennessee Valley Authority, 2009
//  No copyright is claimed pursuant to 17 USC § 105.  All Other Rights Reserved.
//
//  This software is made freely available under the TVA Open Source Agreement (see below).
//  Description: The project is for Loss of Field protection
//
//  Code Modification History:
//  -----------------------------------------------------------------------------------------------------
//  12/02/2009 - Jian R. Zuo
//       Generated original version of source code.
//  12/16/2009 - Jian R. Zuo
//       Reading parameters configuration from database   
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TVA;
using TVA.Measurements;
using TVA.PhasorProtocols;
using TVA.Collections;

namespace EventDetection
{
    /// <summary>
    /// Represents an action adapter that implement logic to detect Loss of Field based on Montgomery PMU.
    /// </summary>
    public class LOFTrigger : CalculatedMeasurementBase
    {
        #region [ Members ]

        // Fields
        private double m_PSet;                                     //Threshold of Pset MW: default value -600 mW      
        private double m_QSet;                                     //Threshold of Qset MVar: default value 200 mVar
        private double m_QAreaSet;                                 //Threshold of Qarea MVar-sec: default value 500 mVar-sec
        private double m_VThreshold;                               //Threshold of Voltage: default value 0.95 p.u. or 475 kV
        private double m_QAreamVar;                                //Calculated Q area value                 
        private int m_interval;                                 //Interval between adjacent check
        private long m_count;                                    //Frame count for debug purpose
        private long m_count1;
        private long m_count2;
        MeasurementKey m_MontVoltageMagnitude;
        MeasurementKey m_MontVoltageAngle;
        MeasurementKey m_MontCurrentMagnitude;
        MeasurementKey m_MontCurrentAngle;
        IMeasurement m_warningSignal;

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Returns the detailed status of the frequency monitor event detector.
        /// </summary>
        public override string Status
        {
            get
            {
                StringBuilder status = new StringBuilder();

                //status.AppendFormat("                Adpater ID: {0}", ID);
                //status.AppendLine();
                status.Append(base.Status);
                return status.ToString();
            }
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Initializes <see cref="FrequencyMonitor"/>.
        /// </summary>
        public override void Initialize()
        {
            base.Initialize();

            Dictionary<string, string> settings = Settings;

#if DEBUG
            OnStatusMessage("********In Initialize()***********");
#endif
            // Load required parameters
            m_PSet = double.Parse(settings["PSet"]);
            m_QSet = double.Parse(settings["QSet"]);
            m_QAreaSet = double.Parse(settings["QAreaSet"]);
            m_VThreshold = double.Parse(settings["VoltageThreshold"]);
            m_interval = int.Parse(settings["CalculateInterval"]);
            m_count = 0;
            m_count1 = 0;
            m_count2 = 0;

            //m_PSet = -600;
            //m_QSet = 200;
            //m_QAreaSet = 500;
            //m_VThreshold = 475000;
            //m_interval = 30;

            // Load needed measurement keys from defined InputMeasurementKeys
            // inputMeasurementKeys={P2:3981;P2:3980;P2:3991;P2:3990}; outputMeasurements={P2:9999}
            m_MontVoltageMagnitude = InputMeasurementKeys[InputMeasurementKeyTypes.IndexOf(signalType => signalType == SignalType.VPHM)];
            m_MontVoltageAngle = InputMeasurementKeys[InputMeasurementKeyTypes.IndexOf(signalType => signalType == SignalType.VPHA)];
            m_MontCurrentMagnitude = InputMeasurementKeys[InputMeasurementKeyTypes.IndexOf(signalType => signalType == SignalType.IPHM)];
            m_MontCurrentAngle = InputMeasurementKeys[InputMeasurementKeyTypes.IndexOf(signalType => signalType == SignalType.IPHA)];

            // Load warning signal output measurement
            m_warningSignal = OutputMeasurements[0];
        }

        /// <summary>
        /// Publishes the <see cref="IFrame"/> of time-aligned collection of <see cref="IMeasurement"/> values that arrived within the
        /// adapter's defined <see cref="ConcentratorBase.LagTime"/>.
        /// </summary>
        /// <param name="frame"><see cref="IFrame"/> of measurements with the same timestamp that arrived within <see cref="ConcentratorBase.LagTime"/> that are ready for processing.</param>
        /// <param name="index">Index of <see cref="IFrame"/> within a second ranging from zero to <c><see cref="ConcentratorBase.FramesPerSecond"/> - 1</c>.</param>
        /// <remarks>
        /// If user implemented publication function consistently exceeds available publishing time (i.e., <c>1 / <see cref="ConcentratorBase.FramesPerSecond"/></c> seconds),
        /// concentration will fall behind. A small amount of this time is required by the <see cref="ConcentratorBase"/> for processing overhead, so actual total time
        /// available for user function process will always be slightly less than <c>1 / <see cref="ConcentratorBase.FramesPerSecond"/></c> seconds.
        /// </remarks>
        protected override void PublishFrame(IFrame frame, int index)
        {
            double voltageMagnitude = 0.0D;
            double voltageAngle = 0.0D;
            double currentMagnitude = 0.0D;
            double currentAngle = 0.0D;
            double realPower;
            double reactivePower;
            double deltaT;
            IMeasurement measurement;
            bool warningSignaled = false;

            m_count++;
#if DEBUG
            if (m_count % 60 == 0)
                OnStatusMessage("{0} events handled...", m_count);
#endif
            if ((m_count % m_interval) == 0)
            {
                m_count1 = m_count2;
                m_count2 = m_count;

                if (frame.Measurements.TryGetValue(m_MontVoltageMagnitude, out measurement))
                    voltageMagnitude = measurement.AdjustedValue;                           
                else
                    OnProcessException(new InvalidOperationException("Failed to receive voltage magnitude - could not calculate loss of field."));

                if (frame.Measurements.TryGetValue(m_MontVoltageAngle, out measurement))
                    voltageAngle = measurement.AdjustedValue / 180.00 * Math.PI;
                else
                    OnProcessException(new InvalidOperationException("Failed to receive voltage angle - could not calculate loss of field.."));

                if (frame.Measurements.TryGetValue(m_MontCurrentMagnitude, out measurement))
                    currentMagnitude = measurement.AdjustedValue;
                else
                    OnProcessException(new InvalidOperationException("Failed to receive current magnitude - could not calculate loss of field.."));

                if (frame.Measurements.TryGetValue(m_MontCurrentAngle, out measurement))
                    currentAngle = measurement.AdjustedValue / 180.00 * Math.PI;                       
                else
                    OnProcessException(new InvalidOperationException("Failed to receive current angle - could not calculate loss of field.."));

                realPower = 3 * voltageMagnitude * currentMagnitude * Math.Cos(voltageAngle - currentAngle) / 1000000.00;
                reactivePower = 3 * voltageMagnitude * currentMagnitude * Math.Sin(voltageAngle - currentAngle) / 1000000.00;
                deltaT = (m_count2 - m_count1) / FramesPerSecond;

                if ((realPower < m_PSet) && (reactivePower > m_QSet))
                {
                    m_QAreamVar = m_QAreamVar + deltaT * (reactivePower - m_QSet);
                    if ((m_QAreamVar > m_QAreaSet) && (voltageMagnitude < (m_VThreshold / Math.Sqrt(3))))
                    {
                        warningSignaled = true;
                        OutputLOFWarning(realPower, reactivePower, m_QAreamVar);
                    }
                }
                else
                    m_QAreamVar = 0;
#if DEBUG
                OnStatusMessage("In ProcessFrames: MontVoltageMagnitude is {0}", voltageMagnitude);
                OnStatusMessage("In ProcessFrames: MontVoltageAngle is {0}", voltageAngle);
                OnStatusMessage("In ProcessFrames: MontCurrentMagnitude is {0}", currentMagnitude);
                OnStatusMessage("In ProcessFrames: MontCurrentAngle is {0}", currentAngle);
                OnStatusMessage("In ProcessFrames: RealPower is {0};ReactivePower is {1}; DeltaT is {2}", realPower, reactivePower, deltaT);
                OnStatusMessage("In ProcessFrames: m_QAreamVar is {0}", m_QAreamVar);
#endif

                // Expose warning signal value
                OnNewMeasurements(new IMeasurement[] {Measurement.Clone(m_warningSignal, warningSignaled ? 1.0D : 0.0D, frame.Timestamp)});
            }
        }

        private void OutputLOFWarning (double realPower, double reactivePower, double QAreamVar)
        {
            OnStatusMessage("************** LOF Warning!!!!!*************");
            OnStatusMessage (string.Format ("The real power is {0}:",realPower ));
            OnStatusMessage (string.Format ("The reactive power is {0}:",reactivePower));
            OnStatusMessage(string.Format("The Q Area is {0}:", QAreamVar));
        }
        #endregion
    }
}
