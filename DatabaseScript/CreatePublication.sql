/****** Scripting replication configuration. Script Date: 8/17/2016 12:34:06 PM ******/
/****** Please Note: For security reasons, all password parameters were scripted with either NULL or an empty string. ******/

/****** Installing the server as a Distributor. Script Date: 8/17/2016 12:34:06 PM ******/
use master
exec sp_adddistributor @distributor = N'[YOUR_MACHINE_NAME]', @password = N''
GO
exec sp_adddistributiondb @database = N'distribution', @data_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data', @log_folder = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\Data', @log_file_size = 2, @min_distretention = 0, @max_distretention = 72, @history_retention = 48, @security_mode = 1
GO

use [distribution] 
if (not exists (select * from sysobjects where name = 'UIProperties' and type = 'U ')) 
	create table UIProperties(id int) 
if (exists (select * from ::fn_listextendedproperty('SnapshotFolder', 'user', 'dbo', 'table', 'UIProperties', null, null))) 
	EXEC sp_updateextendedproperty N'SnapshotFolder', N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\ReplData', 'user', dbo, 'table', 'UIProperties' 
else 
	EXEC sp_addextendedproperty N'SnapshotFolder', N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\ReplData', 'user', dbo, 'table', 'UIProperties'
GO

exec sp_adddistpublisher @publisher = N'[YOUR_MACHINE_NAME]', @distribution_db = N'distribution', @security_mode = 1, @working_directory = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\ReplData', @trusted = N'false', @thirdparty_flag = 0, @publisher_type = N'MSSQLSERVER'
GO

use [EasyMaintainDb]
exec sp_replicationdboption @dbname = N'EasyMaintainDb', @optname = N'publish', @value = N'true'
GO
use [EasyMaintainDb]
exec [EasyMaintainDb].sys.sp_addqreader_agent @job_login = null, @job_password = null, @job_name = null, @frompublisher = 1
GO
-- Adding the transactional publication
use [EasyMaintainDb]
exec sp_addpublication @publication = N'EasyMaintainReplicator', @description = N'Transactional publication with updatable subscriptions of database ''EasyMaintainDb'' from Publisher ''[YOUR_MACHINE_NAME]''.', @sync_method = N'concurrent', @retention = 0, @allow_push = N'true', @allow_pull = N'true', @allow_anonymous = N'true', @enabled_for_internet = N'false', @snapshot_in_defaultfolder = N'true', @compress_snapshot = N'false', @ftp_port = 21, @ftp_login = N'anonymous', @allow_subscription_copy = N'false', @add_to_active_directory = N'false', @repl_freq = N'continuous', @status = N'active', @independent_agent = N'true', @immediate_sync = N'true', @allow_sync_tran = N'true', @autogen_sync_procs = N'true', @allow_queued_tran = N'true', @allow_dts = N'false', @conflict_policy = N'pub wins', @centralized_conflicts = N'true', @conflict_retention = 14, @queue_type = N'sql', @replicate_ddl = 1, @allow_initialize_from_backup = N'false', @enabled_for_p2p = N'false', @enabled_for_het_sub = N'false'
GO


exec sp_addpublication_snapshot @publication = N'EasyMaintainReplicator', @frequency_type = 4, @frequency_interval = 1, @frequency_relative_interval = 1, @frequency_recurrence_factor = 0, @frequency_subday = 8, @frequency_subday_interval = 1, @active_start_time_of_day = 0, @active_end_time_of_day = 235959, @active_start_date = 0, @active_end_date = 0, @job_login = null, @job_password = null, @publisher_security_mode = 1


use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'AircraftModels', @source_owner = N'dbo', @source_object = N'AircraftModels', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'AircraftModels', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'Categories', @source_owner = N'dbo', @source_object = N'Categories', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'Categories', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'EngineTypes', @source_owner = N'dbo', @source_object = N'EngineTypes', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'EngineTypes', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'Inventory', @source_owner = N'dbo', @source_object = N'Inventory', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'Inventory', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'Manufacturers', @source_owner = N'dbo', @source_object = N'Manufacturers', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'Manufacturers', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'SparePart_AircraftModel', @source_owner = N'dbo', @source_object = N'SparePart_AircraftModel', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'SparePart_AircraftModel', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'SparePart_Manufacturer', @source_owner = N'dbo', @source_object = N'SparePart_Manufacturer', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'SparePart_Manufacturer', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'SparePart_Supplier', @source_owner = N'dbo', @source_object = N'SparePart_Supplier', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'SparePart_Supplier', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'SpareParts', @source_owner = N'dbo', @source_object = N'SpareParts', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'SpareParts', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




use [EasyMaintainDb]
exec sp_addarticle @publication = N'EasyMaintainReplicator', @article = N'Suppliers', @source_owner = N'dbo', @source_object = N'Suppliers', @type = N'logbased', @description = null, @creation_script = null, @pre_creation_cmd = N'drop', @schema_option = 0x0000000008035CDF, @identityrangemanagementoption = N'auto', @pub_identity_range = 10000, @identity_range = 1000, @threshold = 80, @destination_table = N'Suppliers', @destination_owner = N'dbo', @status = 16, @vertical_partition = N'false'
GO




