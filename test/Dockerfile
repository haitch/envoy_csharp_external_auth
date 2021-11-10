FROM envoyproxy/envoy-dev:latest

# component-log-level has been tuned to log the details for external auth.
CMD ["/usr/local/bin/envoy", "-c", "/etc/envoy.config.yaml", "--component-log-level", "http:trace,ext_authz:trace"]