Improved ModbusTCP communication stability for CMMT (CMMTt111)

This release improves long-running communication stability between the application and CMMT over ModbusTCP.

What is improved:
Significantly better resistance against intermittent communication dropouts.
Improved automatic recovery behavior after temporary communication disturbances.
More stable cyclic process-data handling to prevent drive-side communication watchdog faults.

User impact:
Existing application integration remains compatible.
No functional workflow changes required for normal usage.
Reliability during long-duration runtime is improved.

