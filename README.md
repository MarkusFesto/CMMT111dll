Customer-Facing Release Note
Title: Improved ModbusTCP communication stability for CMMT (CMMTt111)

This release improves long-running communication stability between the application and CMMT over ModbusTCP.

What is improved
Significantly better resistance against intermittent communication dropouts.
Improved automatic recovery behavior after temporary communication disturbances.
More stable cyclic process-data handling to prevent drive-side communication watchdog faults.
User impact
Existing application integration remains compatible.
No functional workflow changes required for normal usage.
Reliability during long-duration runtime is improved.
Technical Changelog
Component: CMMTt111 (mRH.cs)

Fixed defects
Corrected output register sizing:
numRegOW now based on NoOW (previously incorrect).
Corrected reconnect parameter usage:
reconnect now uses Connect(ip, NoIW, NoOW).
Communication architecture hardening
Consolidated stream ownership to a single worker execution path.
Replaced fragile response handling with deterministic request/response processing:
SendAndProcessResponse(...)
strict frame read (ReadExact(...))
per-function response processing (FC4/FC16/FC3/FC6)
Fixed MBAP response length interpretation (prevents frame over-read/desync).
Timeout and watchdog behavior
Increased default read-timeout baseline and enforced safe lower bound.
Added process-data read timeout cap to avoid long read blocking of cyclic output updates.
Prioritized cyclic output updates to reduce risk of drive watchdog fault 391.
Reconnect robustness
Implemented reconnect state machine with scheduled retries and backoff.
Prevented “stuck” error states after failed reconnect attempts.
Improved failover path to keep attempting recovery automatically.
Stream desynchronization recovery
Added receive-buffer draining after timeout/mismatch scenarios:
DrainAvailableSocketBytes(...)
Added mismatch handling for unexpected function codes.
Added safer behavior on write-response mismatches (resync via reconnect).
Socket/runtime tuning
Enabled NoDelay.
Enabled socket KeepAlive.
Applied safer socket/stream timeout handling.
Notes for validation
Long-duration runtime test stability is significantly improved in field-like conditions.
Monitor log.mrh for:
Read Time Out frequency
unexpected function-code entries
fault 391 recurrence
Current results indicate stable operation over extended runtime.
